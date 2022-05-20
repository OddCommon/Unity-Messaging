using OddCommon.Messaging;


[MessagingInterface]
public interface TestInterfaceReferenceTypes : 
    TestInterfaceClassTypes, TestInterfaceArrayParameter, TestInterfaceGameObjectParameter,
    TestInterfaceMonoBehaviourParameter
{
    
}
