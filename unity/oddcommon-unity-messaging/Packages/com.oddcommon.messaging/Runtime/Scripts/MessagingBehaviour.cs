using UnityEngine;
using UnityEngine.Assertions;


namespace OddCommon.Messaging
{
    public class MessagingBehaviour<T1, T2> : OddBehaviour<T1, T2>
        where T1 : OddBehaviour<T1>
        where T2 : OddScriptableObject<T2>
    {
        #region Fields
        #region Inspector
        [Header("MessagingBehaviour")]
        [SerializeField] protected MessagingManager messagingManager;
        #endregion //Inspector
        #endregion //Fields
        
        #region Methods
        #region Unity Messages
        protected override void Awake()
        {
            base.Awake();
            Assert.IsNotNull(this.messagingManager);
            MessagingManager.RegisterForMessages(this.messagingManager, this);
        }

        protected override void OnDestroy()
        {
            MessagingManager.DeregisterForMessages(this.messagingManager, this);
            base.OnDestroy();
        }
        #endregion //Unity Messages
        #endregion //Methods
    }
}
