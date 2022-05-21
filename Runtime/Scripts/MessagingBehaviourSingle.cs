using UnityEngine;


namespace OddCommon.Messaging
{
    public class MessagingBehaviourSingle<TypeComponent> : OddBehaviourSingle<TypeComponent> where TypeComponent : OddBehaviour
    {
        #region Fields
        #region Inspector
        [Header("MessagingBehaviourSingle")]
        [SerializeField] protected MessagingManager messagingManager;
        [SerializeField] protected bool crossSceneMessagingManager;
        #endregion //Inspector
        #endregion //Fields
        
        #region Methods
        #region Unity Messages
        protected override void Awake()
        {
            base.Awake();
            if (MessagingBehaviourSingle<TypeComponent>.instance == this as TypeComponent)
            {
                if (this.messagingManager == null && this.crossSceneMessagingManager)
                {
                    this.messagingManager = GameObject.FindObjectOfType<MessagingManager>();
                }
                this.messagingManager.RegisterForMessages(this);
            }
        }

        protected override void OnDestroy()
        {
            messagingManager.DeregisterForMessages(this);
            base.OnDestroy();
        }
        #endregion //Unity Messages
        #endregion //Methods
    }
    
    public class MessagingBehaviourSingle<TypeComponent, TypeData> : OddBehaviourSingle<TypeComponent, TypeData> 
        where TypeComponent : OddBehaviour<TypeData>
        where TypeData : OddScriptableObjectSingle<TypeData>
    {
        #region Fields
        #region Inspector
        [Header("MessagingBehaviourSingle")]
        [SerializeField] protected MessagingManager messagingManager;
        [SerializeField] protected bool crossSceneMessagingManager;
        #endregion //Inspector
        #endregion //Fields
        
        #region Methods
        #region Unity Messages
        protected override void Awake()
        {
            base.Awake();
            if (MessagingBehaviourSingle<TypeComponent, TypeData>.instance == this as TypeComponent)
            {
                if (this.messagingManager == null && this.crossSceneMessagingManager)
                {
                    this.messagingManager = GameObject.FindObjectOfType<MessagingManager>();
                }
                this.messagingManager.RegisterForMessages(this);
            }
        }

        protected override void OnDestroy()
        {
            messagingManager.DeregisterForMessages(this);
            base.OnDestroy();
        }
        #endregion //Unity Messages
        #endregion //Methods
    }
}