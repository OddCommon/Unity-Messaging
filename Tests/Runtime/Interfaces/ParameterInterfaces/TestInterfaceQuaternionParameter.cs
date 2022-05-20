using UnityEngine;
using OddCommon.Messaging;


[MessagingInterface]
public interface TestInterfaceQuaternionParameter
{
    void TestMethodQuaternionParameter(Quaternion quaternionParam);
}