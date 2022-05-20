using UnityEngine;


namespace OddCommon.Messaging
{
     public class MessagingBehaviourSingle<T> : OddBehaviourSingle<T> where T : OddBehaviour
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
            if (MessagingBehaviourSingle<T>.instance == this as T)
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