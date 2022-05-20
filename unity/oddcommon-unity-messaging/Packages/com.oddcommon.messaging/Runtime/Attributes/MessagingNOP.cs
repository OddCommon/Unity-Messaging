using System;


namespace OddCommon.Messaging
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class MessagingNOP : Attribute
    {
        // We only use this attribute for tagging methods
        // as not implemented message handlers.
    }
}