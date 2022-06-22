// MessagingExtensions.cs
// Auto-Generated 6/22/2022 9:19:02 PM
using System.Collections.Generic;
using OddCommon.Messaging;
using TestNamespace;


public static class MessagingExtensions
{
    #region TestInterfaceInheritance
    public static void TestMethodInheritanceEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.Quaternion quaternionParam)
    {
        List<TestInterfaceInheritance> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceInheritance>(messagingManager, "TestMethodInheritance");
        foreach (TestInterfaceInheritance listener in allListeners)
        {
            listener.TestMethodInheritance(quaternionParam);
        }
    }
    #endregion

    #region TestInterfaceNoNamespace
    public static void TestMethodNoNamespaceNamespacedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, TestNamespace.TestClassWithNamespace.TestClassWithNamespaceEnum testClassWithNamespaceEnum)
    {
        List<TestInterfaceNoNamespace> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceNoNamespace>(messagingManager, "TestMethodNoNamespaceNamespacedParameter");
        foreach (TestInterfaceNoNamespace listener in allListeners)
        {
            listener.TestMethodNoNamespaceNamespacedParameter(testClassWithNamespaceEnum);
        }
    }

    public static void TestMethodNoNamespaceRegularParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, TestClassNoNamespace.TestClassNoNamespaceEnum testClassNoNamespaceEnum)
    {
        List<TestInterfaceNoNamespace> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceNoNamespace>(messagingManager, "TestMethodNoNamespaceRegularParameter");
        foreach (TestInterfaceNoNamespace listener in allListeners)
        {
            listener.TestMethodNoNamespaceRegularParameter(testClassNoNamespaceEnum);
        }
    }
    #endregion

    #region TestInterfaceBoolParameter
    public static void TestMethodBoolParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Boolean boolParam)
    {
        List<TestInterfaceBoolParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceBoolParameter>(messagingManager, "TestMethodBoolParameter");
        foreach (TestInterfaceBoolParameter listener in allListeners)
        {
            listener.TestMethodBoolParameter(boolParam);
        }
    }
    #endregion

    #region TestInterfaceByteParameter
    public static void TestMethodByteSignedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.SByte signedByteParam)
    {
        List<TestInterfaceByteParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceByteParameter>(messagingManager, "TestMethodByteSignedParameter");
        foreach (TestInterfaceByteParameter listener in allListeners)
        {
            listener.TestMethodByteSignedParameter(signedByteParam);
        }
    }

    public static void TestMethodByteUnsignedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Byte unsignedByteParam)
    {
        List<TestInterfaceByteParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceByteParameter>(messagingManager, "TestMethodByteUnsignedParameter");
        foreach (TestInterfaceByteParameter listener in allListeners)
        {
            listener.TestMethodByteUnsignedParameter(unsignedByteParam);
        }
    }

    public static void TestMethodByteParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.SByte signedByteParam, System.Byte unsignedByteParam)
    {
        List<TestInterfaceByteParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceByteParameter>(messagingManager, "TestMethodByteParameter");
        foreach (TestInterfaceByteParameter listener in allListeners)
        {
            listener.TestMethodByteParameter(signedByteParam, unsignedByteParam);
        }
    }
    #endregion

    #region TestInterfaceCharParameter
    public static void TestMethodCharParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Char charParam)
    {
        List<TestInterfaceCharParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceCharParameter>(messagingManager, "TestMethodCharParameter");
        foreach (TestInterfaceCharParameter listener in allListeners)
        {
            listener.TestMethodCharParameter(charParam);
        }
    }
    #endregion

    #region TestInterfaceClassParameter
    public static void TestMethodClassParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, TestClass classPrameter)
    {
        List<TestInterfaceClassParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceClassParameter>(messagingManager, "TestMethodClassParameter");
        foreach (TestInterfaceClassParameter listener in allListeners)
        {
            listener.TestMethodClassParameter(classPrameter);
        }
    }
    #endregion

    #region TestInterfaceDoubleParameter
    public static void TestMethodDoubleParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Double doubleParam)
    {
        List<TestInterfaceDoubleParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceDoubleParameter>(messagingManager, "TestMethodDoubleParameter");
        foreach (TestInterfaceDoubleParameter listener in allListeners)
        {
            listener.TestMethodDoubleParameter(doubleParam);
        }
    }
    #endregion

    #region TestInterfaceEnumParameter
    public static void TestMethodEnumParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, TestEnum enumParam)
    {
        List<TestInterfaceEnumParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceEnumParameter>(messagingManager, "TestMethodEnumParameter");
        foreach (TestInterfaceEnumParameter listener in allListeners)
        {
            listener.TestMethodEnumParameter(enumParam);
        }
    }
    #endregion

    #region TestInterfaceFloatParameter
    public static void TestMethodFloatParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Single floatParam)
    {
        List<TestInterfaceFloatParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceFloatParameter>(messagingManager, "TestMethodFloatParameter");
        foreach (TestInterfaceFloatParameter listener in allListeners)
        {
            listener.TestMethodFloatParameter(floatParam);
        }
    }
    #endregion

    #region TestInterfaceGameObjectParameter
    public static void TestMethodGameObjectParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.GameObject gameObjectParameter)
    {
        List<TestInterfaceGameObjectParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceGameObjectParameter>(messagingManager, "TestMethodGameObjectParameter");
        foreach (TestInterfaceGameObjectParameter listener in allListeners)
        {
            listener.TestMethodGameObjectParameter(gameObjectParameter);
        }
    }
    #endregion

    #region TestInterfaceIntParameter
    public static void TestMethodIntSignedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Int32 signedIntParam)
    {
        List<TestInterfaceIntParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceIntParameter>(messagingManager, "TestMethodIntSignedParameter");
        foreach (TestInterfaceIntParameter listener in allListeners)
        {
            listener.TestMethodIntSignedParameter(signedIntParam);
        }
    }

    public static void TestMethodIntUnsignedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.UInt32 unsignedIntParam)
    {
        List<TestInterfaceIntParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceIntParameter>(messagingManager, "TestMethodIntUnsignedParameter");
        foreach (TestInterfaceIntParameter listener in allListeners)
        {
            listener.TestMethodIntUnsignedParameter(unsignedIntParam);
        }
    }

    public static void TestMethodIntParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Int32 signedIntParam, System.UInt32 unsignedIntParam)
    {
        List<TestInterfaceIntParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceIntParameter>(messagingManager, "TestMethodIntParameter");
        foreach (TestInterfaceIntParameter listener in allListeners)
        {
            listener.TestMethodIntParameter(signedIntParam, unsignedIntParam);
        }
    }
    #endregion

    #region TestInterfaceLongParameter
    public static void TestMethodLongSignedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Int64 signedLongParam)
    {
        List<TestInterfaceLongParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceLongParameter>(messagingManager, "TestMethodLongSignedParameter");
        foreach (TestInterfaceLongParameter listener in allListeners)
        {
            listener.TestMethodLongSignedParameter(signedLongParam);
        }
    }

    public static void TestMethodLongUnsignedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.UInt64 unsignedLongParam)
    {
        List<TestInterfaceLongParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceLongParameter>(messagingManager, "TestMethodLongUnsignedParameter");
        foreach (TestInterfaceLongParameter listener in allListeners)
        {
            listener.TestMethodLongUnsignedParameter(unsignedLongParam);
        }
    }

    public static void TestMethodLongParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Int64 signedLongParam, System.UInt64 unsignedLongParam)
    {
        List<TestInterfaceLongParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceLongParameter>(messagingManager, "TestMethodLongParameter");
        foreach (TestInterfaceLongParameter listener in allListeners)
        {
            listener.TestMethodLongParameter(signedLongParam, unsignedLongParam);
        }
    }
    #endregion

    #region TestInterfaceMonoBehaviourParameter
    public static void TestMethodMonoBehaviourParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.MonoBehaviour monoBehaviourParameter)
    {
        List<TestInterfaceMonoBehaviourParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceMonoBehaviourParameter>(messagingManager, "TestMethodMonoBehaviourParameter");
        foreach (TestInterfaceMonoBehaviourParameter listener in allListeners)
        {
            listener.TestMethodMonoBehaviourParameter(monoBehaviourParameter);
        }
    }
    #endregion

    #region TestInterfaceNoParameter
    public static void TestMethodNoParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager)
    {
        List<TestInterfaceNoParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceNoParameter>(messagingManager, "TestMethodNoParameter");
        foreach (TestInterfaceNoParameter listener in allListeners)
        {
            listener.TestMethodNoParameter();
        }
    }
    #endregion

    #region TestInterfaceOddBehaviourParameter
    public static void TestMethodOddBehaviourParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, OddCommon.OddBehaviour oddBehaviourParameter)
    {
        List<TestInterfaceOddBehaviourParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceOddBehaviourParameter>(messagingManager, "TestMethodOddBehaviourParameter");
        foreach (TestInterfaceOddBehaviourParameter listener in allListeners)
        {
            listener.TestMethodOddBehaviourParameter(oddBehaviourParameter);
        }
    }
    #endregion

    #region TestInterfaceOddBehaviourSingletonParameter
    public static void TestMethodOddBehaviourSingletonParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, TestClassOddBehaviourSingle oddBehaviourSingleParameter)
    {
        List<TestInterfaceOddBehaviourSingletonParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceOddBehaviourSingletonParameter>(messagingManager, "TestMethodOddBehaviourSingletonParameter");
        foreach (TestInterfaceOddBehaviourSingletonParameter listener in allListeners)
        {
            listener.TestMethodOddBehaviourSingletonParameter(oddBehaviourSingleParameter);
        }
    }
    #endregion

    #region TestInterfaceOddScriptableObjectParameter
    public static void TestMethodOddScriptableObjectParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, OddCommon.OddScriptableObject oddScriptableObjectParameter)
    {
        List<TestInterfaceOddScriptableObjectParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceOddScriptableObjectParameter>(messagingManager, "TestMethodOddScriptableObjectParameter");
        foreach (TestInterfaceOddScriptableObjectParameter listener in allListeners)
        {
            listener.TestMethodOddScriptableObjectParameter(oddScriptableObjectParameter);
        }
    }
    #endregion

    #region TestInterfaceOddScriptableObjectSingletonParameter
    public static void TestMethodOddScriptableObjectSingletonParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, TestClassOddScriptableObjectSingle oddScriptableObjectSingletonParameter)
    {
        List<TestInterfaceOddScriptableObjectSingletonParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceOddScriptableObjectSingletonParameter>(messagingManager, "TestMethodOddScriptableObjectSingletonParameter");
        foreach (TestInterfaceOddScriptableObjectSingletonParameter listener in allListeners)
        {
            listener.TestMethodOddScriptableObjectSingletonParameter(oddScriptableObjectSingletonParameter);
        }
    }
    #endregion

    #region TestInterfaceQuaternionParameter
    public static void TestMethodQuaternionParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.Quaternion quaternionParam)
    {
        List<TestInterfaceQuaternionParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceQuaternionParameter>(messagingManager, "TestMethodQuaternionParameter");
        foreach (TestInterfaceQuaternionParameter listener in allListeners)
        {
            listener.TestMethodQuaternionParameter(quaternionParam);
        }
    }
    #endregion

    #region TestInterfaceScriptableObjectParameter
    public static void TestMethodScriptableObjectParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.ScriptableObject scriptableObjectParameter)
    {
        List<TestInterfaceScriptableObjectParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceScriptableObjectParameter>(messagingManager, "TestMethodScriptableObjectParameter");
        foreach (TestInterfaceScriptableObjectParameter listener in allListeners)
        {
            listener.TestMethodScriptableObjectParameter(scriptableObjectParameter);
        }
    }
    #endregion

    #region TestInterfaceShortParaeter
    public static void TestMethodShortSignedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Int16 signedShortParam)
    {
        List<TestInterfaceShortParaeter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceShortParaeter>(messagingManager, "TestMethodShortSignedParameter");
        foreach (TestInterfaceShortParaeter listener in allListeners)
        {
            listener.TestMethodShortSignedParameter(signedShortParam);
        }
    }

    public static void TestMethodShortUnsignedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.UInt16 unsignedShortParam)
    {
        List<TestInterfaceShortParaeter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceShortParaeter>(messagingManager, "TestMethodShortUnsignedParameter");
        foreach (TestInterfaceShortParaeter listener in allListeners)
        {
            listener.TestMethodShortUnsignedParameter(unsignedShortParam);
        }
    }

    public static void TestMethodShortParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Int16 signedShortParam, System.UInt16 unsignedShortParam)
    {
        List<TestInterfaceShortParaeter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceShortParaeter>(messagingManager, "TestMethodShortParameter");
        foreach (TestInterfaceShortParaeter listener in allListeners)
        {
            listener.TestMethodShortParameter(signedShortParam, unsignedShortParam);
        }
    }
    #endregion

    #region TestInterfaceStringParameter
    public static void TestMethodStringParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.String stringParam)
    {
        List<TestInterfaceStringParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceStringParameter>(messagingManager, "TestMethodStringParameter");
        foreach (TestInterfaceStringParameter listener in allListeners)
        {
            listener.TestMethodStringParameter(stringParam);
        }
    }
    #endregion

    #region TestInterfaceStructParameter
    public static void TestMethodStructParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, TestStruct structParam)
    {
        List<TestInterfaceStructParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceStructParameter>(messagingManager, "TestMethodStructParameter");
        foreach (TestInterfaceStructParameter listener in allListeners)
        {
            listener.TestMethodStructParameter(structParam);
        }
    }
    #endregion

    #region TestInterfaceUnityEngineObjectParameter
    public static void TestMethodUnityEngineObjectParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.Object unityEngineObjectParameter)
    {
        List<TestInterfaceUnityEngineObjectParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceUnityEngineObjectParameter>(messagingManager, "TestMethodUnityEngineObjectParameter");
        foreach (TestInterfaceUnityEngineObjectParameter listener in allListeners)
        {
            listener.TestMethodUnityEngineObjectParameter(unityEngineObjectParameter);
        }
    }
    #endregion

    #region TestInterfaceVectorParameter
    public static void TestMethodVector2ParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.Vector2 vector2Param)
    {
        List<TestInterfaceVectorParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceVectorParameter>(messagingManager, "TestMethodVector2Parameter");
        foreach (TestInterfaceVectorParameter listener in allListeners)
        {
            listener.TestMethodVector2Parameter(vector2Param);
        }
    }

    public static void TestMethodVector3ParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.Vector3 vector3Param)
    {
        List<TestInterfaceVectorParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceVectorParameter>(messagingManager, "TestMethodVector3Parameter");
        foreach (TestInterfaceVectorParameter listener in allListeners)
        {
            listener.TestMethodVector3Parameter(vector3Param);
        }
    }

    public static void TestMethodVector4ParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.Vector4 vector4Param)
    {
        List<TestInterfaceVectorParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceVectorParameter>(messagingManager, "TestMethodVector4Parameter");
        foreach (TestInterfaceVectorParameter listener in allListeners)
        {
            listener.TestMethodVector4Parameter(vector4Param);
        }
    }

    public static void TestMethodVector2IntParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.Vector2Int vector2IntParam)
    {
        List<TestInterfaceVectorParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceVectorParameter>(messagingManager, "TestMethodVector2IntParameter");
        foreach (TestInterfaceVectorParameter listener in allListeners)
        {
            listener.TestMethodVector2IntParameter(vector2IntParam);
        }
    }

    public static void TestMethodVector3IntParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, UnityEngine.Vector3Int vector3IntParam)
    {
        List<TestInterfaceVectorParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceVectorParameter>(messagingManager, "TestMethodVector3IntParameter");
        foreach (TestInterfaceVectorParameter listener in allListeners)
        {
            listener.TestMethodVector3IntParameter(vector3IntParam);
        }
    }
    #endregion

    #region TestInterfaceArrayParameter
    public static void TestMethodIntArrayParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Int32[] arrayParam)
    {
        List<TestInterfaceArrayParameter> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceArrayParameter>(messagingManager, "TestMethodIntArrayParameter");
        foreach (TestInterfaceArrayParameter listener in allListeners)
        {
            listener.TestMethodIntArrayParameter(arrayParam);
        }
    }
    #endregion

    #region TestInterfaceInNamespace
    public static void TestMethodInNamespaceNamespacedParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, TestNamespace.TestClassWithNamespace.TestClassWithNamespaceEnum testClassWithNamespaceEnum)
    {
        List<TestInterfaceInNamespace> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceInNamespace>(messagingManager, "TestMethodInNamespaceNamespacedParameter");
        foreach (TestInterfaceInNamespace listener in allListeners)
        {
            listener.TestMethodInNamespaceNamespacedParameter(testClassWithNamespaceEnum);
        }
    }

    public static void TestMethodInNamespaceRegularParameterEvent(this OddCommon.Messaging.MessagingManager messagingManager, TestClassNoNamespace.TestClassNoNamespaceEnum testClassNoNamespaceEnum)
    {
        List<TestInterfaceInNamespace> allListeners = MessagingManager.GetRegisteredListeners<TestInterfaceInNamespace>(messagingManager, "TestMethodInNamespaceRegularParameter");
        foreach (TestInterfaceInNamespace listener in allListeners)
        {
            listener.TestMethodInNamespaceRegularParameter(testClassNoNamespaceEnum);
        }
    }
    #endregion
}
