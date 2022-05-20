using OddCommon.Debug;
using UnityEngine;


namespace OddCommon.Messaging
{
    public class MessagingBehaviour : OddBehaviour
    {
        #region Fields
        #region Inspector
        [Header("MessagingBehaviour")]
        [SerializeField] protected MessagingManager messagingManager;
        [SerializeField] protected bool crossSceneMessagingManager;
        #endregion //Inspector
        #endregion //Fields
        
        #region Methods
        #region Unity Messages
        protected virtual void Awake()
        {
            if (this.messagingManager == null && this.crossSceneMessagingManager)
            {
                this.messagingManager = GameObject.FindObjectOfType<MessagingManager>();
            }
            this.messagingManager.RegisterForMessages(this);
        }

        protected virtual void OnDestroy()
        {
            this.messagingManager.DeregisterForMessages(this);
        }
        #endregion //Unity Messages
        #endregion //Methods
    }
}
