using OddCommon.Messaging;


[MessagingInterface]
public interface TestInterfaceSimpleTypes :
    TestInterfaceByteParameter, TestInterfaceShortParaeter, TestInterfaceIntParameter, 
    TestInterfaceLongParameter, TestInterfaceCharParameter, TestInterfaceFloatParameter, 
    TestInterfaceDoubleParameter, TestInterfaceBoolParameter
{
   
}