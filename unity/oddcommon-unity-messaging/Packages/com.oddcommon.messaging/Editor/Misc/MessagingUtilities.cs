using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using OddCommon.Debug;
using UnityEngine;
using Assembly = System.Reflection.Assembly;
using UnityAssembly = UnityEditor.Compilation.Assembly;
using PackageInfo = UnityEditor.PackageManager.PackageInfo;


namespace OddCommon.Messaging.Editor
{
    public class MessagingUtilities
    {
        #region Class
        #region Methods
        #region Internal
        internal static Hash128 GetProjectUniqueHash128(string data)
        {
            Hash128 hash = Hash128.Compute(PlayerSettings.productGUID.ToString());
            hash.Append(data);
            return hash;
        }
        
        internal static bool GetSaveAssetPath(string filename, string fileExtension, out string path)
        {
            string className = nameof( MessagingUtilities );
            string filenameFull = filename + fileExtension;
            string saveFolderPanelTitle = "Folder to save " + filenameFull + " to";
            string saveFileSelectedPath =
                EditorUtility.SaveFolderPanel
                (
                    saveFolderPanelTitle,
                    MessagingConstants.defaultAssetsPath,
                    ""
                );
            if (saveFileSelectedPath == string.Empty)
            {
                // User cancelled out of selecting a location
                Logging.Warn("[{0}] No location selected for {1}; exiting.", className, filenameFull);
                path = null;
                return false;
            }
            bool foundAssetSubfolder = saveFileSelectedPath.Contains( "Assets" ) || saveFileSelectedPath.Contains( "Packages" );
            if (foundAssetSubfolder)
            {
                string userSelectedPathFormat =
                    "[{0}] Saving {1} at user selected location at {2}.";
                Logging.Log(userSelectedPathFormat, className, filenameFull, saveFileSelectedPath);
                path = saveFileSelectedPath + Path.DirectorySeparatorChar + filenameFull;
                return true;
            }
            else
            {
                string userSelectedPathNotFoundFormat =
                    "[{0}] Please select a path to save {1} to inside the Assets subfolder.";
                Logging.Log(userSelectedPathNotFoundFormat, className, filenameFull);
                path = null;
                return false;
            }
        }

        internal static List<string> GetControlPanelNamespaceAndTitle(string controlPanelScriptFilepath)
        {
            List<string> controlPanelNamespaceAndTitle = new List<string>();
            controlPanelNamespaceAndTitle.Add
            (
                EditorPrefs.GetString
                (
                    MessagingUtilities.GetProjectUniqueHash128(MessagingConstants.messagingNamespaceKey).ToString(),
                    ""
                )
            );
            controlPanelNamespaceAndTitle.Add
            (
                EditorPrefs.GetString
                (
                    MessagingUtilities.GetProjectUniqueHash128(MessagingConstants.messagingTitleKey).ToString(),
                    ""
                )
            );
            if (String.IsNullOrEmpty(controlPanelNamespaceAndTitle[0]) || String.IsNullOrEmpty(controlPanelNamespaceAndTitle[1]))
            {
                //Ask for new namespace and title from user
                string modalTitle = "ENTER DESIRED CONTROL PANEL NAMESPACE AND TITLE";
                controlPanelNamespaceAndTitle =
                    MessagingControlPanelNamespaceAndTitleInputModal.Show
                    (
                        modalTitle,
                        controlPanelNamespaceAndTitle[0],
                        controlPanelNamespaceAndTitle[1]
                    );
            }
            return controlPanelNamespaceAndTitle;
        }
        
        internal static Type[] GetMessagingInterfaceTypes()
        {
            Assembly[] allAssemblies = System.AppDomain.CurrentDomain.GetAssemblies();
            UnityAssembly[] playerAssemblies = CompilationPipeline.GetAssemblies(AssembliesType.Player);
            List<Assembly> playerFilteredAssemblies = new List<Assembly>();
            ListRequest packageListRequest = Client.List();
            List<Assembly> packageFilteredAssemblies = new List<Assembly>();
            List<Type> interfaceTypes = new List<Type>();
            // Interleave some of the player assembly filtering with waiting for the package list request
            int playerAssemblyIndex = 0;
            while (!packageListRequest.IsCompleted)
            {
                if (playerAssemblyIndex < playerAssemblies.Length)
                {
                    foreach (Assembly assembly in allAssemblies)
                    {
                        if (assembly.GetName().Name == playerAssemblies[playerAssemblyIndex].name)
                        {
                            playerFilteredAssemblies.Add(assembly);
                            playerAssemblyIndex++;
                            break;
                        }
                    }
                }
            }
            // Finish up player assembly filtering if we need to
            for (int i = playerAssemblyIndex; i < playerAssemblies.Length; i++)
            {
                foreach (Assembly assembly in allAssemblies)
                {
                    if (assembly.GetName().Name == playerAssemblies[playerAssemblyIndex].name)
                    {
                        playerFilteredAssemblies.Add(assembly);
                        break;
                    }
                }
            }
            if (packageListRequest.Error != null)
            {
                Logging.Error("[MessagingEventsAutoGenerator.GetMessagingInterfaceTypes] Package list request returned an error.");
            }
            else
            {
                foreach (Assembly assembly in playerFilteredAssemblies)
                {
                    PackageInfo packageInfo = PackageInfo.FindForAssembly( assembly );
                    if (packageInfo == null || packageInfo.source == PackageSource.Embedded)
                    {
                        packageFilteredAssemblies.Add(assembly);
                    }
                }
            }
            foreach (Assembly assembly in packageFilteredAssemblies)
            {
                Type[] assemblyTypes = assembly.GetTypes();
                foreach (Type potentialType in assemblyTypes)
                {
                    if (potentialType.IsInterface)
                    {
                        MessagingInterface messagingInterfaceAttribute = potentialType.GetCustomAttribute<MessagingInterface>();
                        if (messagingInterfaceAttribute != null)
                        {
                            interfaceTypes.Add(potentialType);
                        }   
                    }
                }
            }
            return interfaceTypes.ToArray();
        }

        internal static bool ParameterTypeCheck(Type type)
        {
            bool parameterTypeIsSupported = false;
            
            parameterTypeIsSupported |= type == typeof(Boolean);
            parameterTypeIsSupported |= type == typeof(Byte);
            parameterTypeIsSupported |= type == typeof(SByte);
            parameterTypeIsSupported |= type == typeof(Single);
            parameterTypeIsSupported |= type == typeof(Double);
            parameterTypeIsSupported |= type == typeof(Int16);
            parameterTypeIsSupported |= type == typeof(UInt16);
            parameterTypeIsSupported |= type == typeof(Int32);
            parameterTypeIsSupported |= type == typeof(UInt32);
            parameterTypeIsSupported |= type == typeof(Int64);
            parameterTypeIsSupported |= type == typeof(UInt64);
            parameterTypeIsSupported |= type == typeof(String);
            parameterTypeIsSupported |= type == typeof(Char);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Vector2);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Vector2Int);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Vector3);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Vector3Int);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Vector4);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Rect);
            parameterTypeIsSupported |= type == typeof(UnityEngine.RectInt);
            parameterTypeIsSupported |= type == typeof(UnityEngine.RectOffset);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Quaternion);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Color);
            parameterTypeIsSupported |= type == typeof(UnityEngine.LayerMask);
            parameterTypeIsSupported |= type == typeof(UnityEngine.AnimationCurve);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Gradient);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Bounds);
            parameterTypeIsSupported |= type == typeof(UnityEngine.BoundsInt);
            parameterTypeIsSupported |= (type.IsEnum && type.IsSerializable);
            parameterTypeIsSupported |= (type.IsValueType && type.IsSerializable && !type.IsEnum);
            parameterTypeIsSupported |= 
                (type.IsClass && type.IsSerializable && !type.IsAbstract && !type.IsGenericType);
            parameterTypeIsSupported |= type == typeof(UnityEngine.Object);
            parameterTypeIsSupported |= 
                (type.IsSubclassOf(typeof(UnityEngine.Object)) && !type.IsAbstract && !type.IsGenericType);
            parameterTypeIsSupported |= type == typeof(UnityEngine.GameObject);
            parameterTypeIsSupported |= 
                (type.IsSubclassOf(typeof(UnityEngine.GameObject)) && !type.IsAbstract && !type.IsGenericType);
            parameterTypeIsSupported |= type == typeof(UnityEngine.ScriptableObject);
            parameterTypeIsSupported |= 
                (type.IsSubclassOf(typeof(UnityEngine.ScriptableObject)) && !type.IsAbstract && !type.IsGenericType);
            parameterTypeIsSupported |= type.IsArray && ParameterTypeCheck(type.GetElementType());
            parameterTypeIsSupported |= (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>));
            
            return parameterTypeIsSupported;
        }

        internal static string GetParameterTypeAsString(Type type)
        {
            string typeAsString = type.Name;
            
            if (type.IsNested)
            {
                if (typeAsString.Contains("+"))
                {
                    typeAsString = typeAsString.ToString().Replace("+", ".");
                }
                else if (type.DeclaringType != null)
                {
                    typeAsString = type.DeclaringType.Name + "." + typeAsString;
                }
            }
            if (type.IsGenericType)
            {
                typeAsString = typeAsString.Replace("`1", "<");
                foreach (Type genericType in type.GenericTypeArguments)
                {
                    typeAsString += MessagingUtilities.GetParameterTypeAsString(genericType);
                }
                typeAsString += ">";
            }
            if (typeAsString == "Object")
            {
                typeAsString = type.Namespace + "." + typeAsString;
            }
            
            return typeAsString;
        }
        #endregion //Internal
        #endregion //Methods
        #endregion //Class
    }
}