using UnityEngine;
using OddCommon.Messaging;


[MessagingInterface]
public interface TestInterfaceInheritance : TestInterfaceValueTypes, TestInterfaceReferenceTypes
{
    void TestMethodInheritance(Quaternion quaternionParam);
}
