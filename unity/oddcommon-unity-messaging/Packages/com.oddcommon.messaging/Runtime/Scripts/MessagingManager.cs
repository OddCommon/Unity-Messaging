using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using OddCommon.Debug;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace OddCommon.Messaging
{
    [DefaultExecutionOrder(Int32.MinValue + 1)]
    public class MessagingManager : OddBehaviour<MessagingManager>
    {
        #region Class
        #region Methods
        #region Public
        public static bool RegisterForMessages(MessagingManager messagingManager, OddBehaviour listener)
        {
            if (messagingManager == null)
            {
                messagingManager = MessagingManager.FindValidMessagingManager(listener.gameObject.scene);
            }
            bool registrationSuccessful = false;
            if (messagingManager != null)
            {
                Logging.Log(listener.name + " - Registering all messaging methods.");
                Type listenerType = listener.GetType();
                if (!messagingManager.RegisterForMessagesFromCache(listenerType, listener))
                {
                    List<string> listenerMethodNames = new List<string>();
                    MethodInfo[] listenerMethods = listenerType.GetMethods();
                    foreach (MethodInfo method in listenerMethods)
                    {
                        // Filter out all methods which have the MessagingNOP attribute
                        MessagingNOP messagingNOPAttribute = method.GetCustomAttribute<MessagingNOP>();
                        if (messagingNOPAttribute == null)
                        {
                            listenerMethodNames.Add(method.Name);
                        }
                    }

                    // Find all messaging interfaces this component adheres to
                    Type[] listerInterfaces = listenerType.GetInterfaces();
                    List<Type> messagingInterfaces = new List<Type>();
                    foreach (Type potentialInterfaceType in listerInterfaces)
                    {
                        MessagingInterface messagingInterfaceAttribute = potentialInterfaceType.GetCustomAttribute<MessagingInterface>();
                        if (messagingInterfaceAttribute != null)
                        {
                            messagingInterfaces.Add(potentialInterfaceType);
                        }
                    }

                    // Register for messages with the MessagingManager while building cache entry
                    List<MessageKey> messagesToCache = new List<MessageKey>();
                    foreach(Type messagingInterfaceType in messagingInterfaces)
                    {
                        MethodInfo[] interfaceMethods = messagingInterfaceType.GetMethods(); 
                        foreach (MethodInfo method in interfaceMethods)
                        { 
                            if (listenerMethodNames.Contains(method.Name))  // We have to match the names of the methods
                            {
                                // Register for message
                                MessageKey key = new MessageKey { type = messagingInterfaceType, message = method.Name };
                                messagingManager.RegisterForMessagesInternal(key, listener);
                                messagesToCache.Add(key);
                            }
                        }
                    }
                    messagingManager.AddMessagesToCache(listenerType, messagesToCache);
                }
                registrationSuccessful = true;
            }
            return registrationSuccessful;
        }

        public static void DeregisterForMessages(MessagingManager messagingManager, OddBehaviour listener)
        {
            if (messagingManager == null)
            {
                messagingManager = MessagingManager.FindValidMessagingManager(listener.gameObject.scene);
            }
            if (messagingManager != null)
            {
                messagingManager.DeregisterForMessagesInternal(listener);
            }
        }

        public static MessagingManager FindValidMessagingManager(Scene scene)
        {
            MessagingManager[] messagingManagers = GameObject.FindObjectsOfType<MessagingManager>();
            foreach (MessagingManager messagingManager in messagingManagers)
            {
                if (!messagingManager.isBeingDestroyed && messagingManager.isActiveAndEnabled && messagingManager.gameObject.scene == scene)
                {
                    return messagingManager;
                }
            }
            return null;
        }
        
        public static List<T> GetRegisteredListeners<T>(MessagingManager messagingManager, string messageName)
        {
            if (messagingManager != null)
            {
                return messagingManager.GetRegisteredListenersInternal<T>(messageName);
            }
            else
            {
                // We return an empty list here if the messaging manager does not
                // currently exist. This should only happen if an event is called
                // during boot-up or shutdown, so the impact to garbage collection
                // can be ignored.
                return new List<T>();
            }
        }
        #endregion //Public
        #endregion //Methods
        #endregion //Class
        
        #region Instance
        #region Fields
        #region Protected
        protected struct MessageKey
        {
            internal Type type;
            internal string message;
        }
        protected Dictionary<MessageKey, List<OddBehaviour>> messageReceivers;
        protected Dictionary<OddBehaviour, List<MessageKey>> messageKeys;
        protected Dictionary<Type, List<MessageKey>> typeMessages;
        #endregion //Protected
        #endregion //Fields

        #region Methods
        #region Unity Messages
        protected override void Awake()
        {
            base.Awake();
            Logging.Log("[{0}] Initializing", this.name);
            this.messageReceivers = new Dictionary<MessageKey, List<OddBehaviour>>();
            this.messageKeys = new Dictionary<OddBehaviour, List<MessageKey>>();
            this.typeMessages = new Dictionary<Type, List<MessageKey>>();
        }

        protected override void OnDestroy()
        {
            Logging.Log("[{0}] Shutting down.",this.name);
            this.messageReceivers.Clear();
            this.messageKeys.Clear();
            this.typeMessages.Clear();
            base.OnDestroy();
        }
        #endregion //Unity Messages

        #region Protected
        protected virtual bool RegisterForMessagesFromCache(Type interfaceType, OddBehaviour listener)
        {
            bool successfullyRegisteredFromCache = false;
            this.typeMessages.TryGetValue(interfaceType, out List<MessageKey> cachedMessages);
            if (cachedMessages != null)
            {
                foreach (MessageKey key in cachedMessages)
                {
                    this.RegisterForMessagesInternal(key, listener);
                }
                successfullyRegisteredFromCache = true;
            }
            return successfullyRegisteredFromCache;
        }
        
        protected virtual void AddMessagesToCache(Type interfaceType, List<MessageKey> messages)
        {
            if (this.typeMessages.ContainsKey(interfaceType))
            {
                this.typeMessages.Remove(interfaceType);
            }
            this.typeMessages.Add(interfaceType, messages);
        }

        protected virtual void RegisterForMessagesInternal(MessageKey key, OddBehaviour listener)
        {
            // Register listener
            this.messageReceivers.TryGetValue(key, out List<OddBehaviour> registeredListeners);
            if (registeredListeners == null)
            {
                registeredListeners = new List<OddBehaviour>();
                registeredListeners.Add(listener);
                this.messageReceivers.Add(key, registeredListeners);
            }
            else if (!registeredListeners.Contains(listener))
            {
                registeredListeners.Add(listener);
            }
            
            // Add key to registeredKeys if needed
            this.messageKeys.TryGetValue(listener, out List<MessageKey> registeredKeys);
            if (registeredKeys == null)
            {
                registeredKeys = new List<MessageKey>();
                registeredKeys.Add(key);
                this.messageKeys.Add(listener, registeredKeys);
            }
            else if (!registeredKeys.Contains(key))
            {
                registeredKeys.Add(key);
            }
        }

        protected virtual void DeregisterForMessagesInternal(OddBehaviour listener)
        {
            List<MessageKey> registeredKeys;
            this.messageKeys.TryGetValue(listener, out registeredKeys);
            if (registeredKeys != null)
            {
                foreach (MessageKey keyToRemove in registeredKeys)
                {
                    List<OddBehaviour> registeredListeners;
                    this.messageReceivers.TryGetValue(keyToRemove, out registeredListeners);
                    if (registeredListeners != null && registeredListeners.Contains(listener))
                    {
                        registeredListeners.Remove(listener);
                    }
                }
            }
        }

        protected virtual List<T> GetRegisteredListenersInternal<T>(string messageName)
        {
            List<OddBehaviour> registeredListeners;
            MessageKey key = new MessageKey { type = typeof(T), message = messageName };
            this.messageReceivers.TryGetValue(key, out registeredListeners);
            if (registeredListeners == null)
            {
                // Add empty list if this is the first time this event has been fired
                registeredListeners = new List<OddBehaviour>();
                this.messageReceivers.Add(key, registeredListeners);
            }
            return registeredListeners.Cast<T>().ToList();
        }
        #endregion //Protected
        #endregion //Methods
        #endregion //Instance
    }
}
