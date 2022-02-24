#if UNITY_EDITOR
// MessagingControlPanel.cs
// Auto-Generated 3/20/2021 7:35:37 PM
using UnityEngine;
using UnityEditor;
using OddCommon.Debug;
using TestNamespace;
using System;
using OddCommon;
using OddCommon.Messaging;
using OddCommon.Messaging.Editor;



namespace Pixeltheory.Messaging.Editor
{
    public class MessagingControlPanel : EditorWindow
    {
        #region Fields
        #region Private
        #region Editor Window
        private Vector2 guiScrollPosition = Vector2.zero;
        #endregion //Editor Window

        #region Message Parameters
        #region TestInterfaceInheritance Parameters
        private bool foldoutToggleTestInterfaceInheritance = false;
        [SerializeField] private Quaternion TestMethodInheritancequaternionParam;
        #endregion //TestInterfaceInheritance Parameters

        #region TestInterfaceNoNamespace Parameters
        private bool foldoutToggleTestInterfaceNoNamespace = false;
        [SerializeField] private TestClassWithNamespace.TestClassWithNamespaceEnum TestMethodNoNamespaceNamespacedParametertestClassWithNamespaceEnum;
        [SerializeField] private TestClassNoNamespace.TestClassNoNamespaceEnum TestMethodNoNamespaceRegularParametertestClassNoNamespaceEnum;
        #endregion //TestInterfaceNoNamespace Parameters

        #region TestInterfaceBoolParameter Parameters
        private bool foldoutToggleTestInterfaceBoolParameter = false;
        [SerializeField] private Boolean TestMethodBoolParameterboolParam;
        #endregion //TestInterfaceBoolParameter Parameters

        #region TestInterfaceByteParameter Parameters
        private bool foldoutToggleTestInterfaceByteParameter = false;
        [SerializeField] private SByte TestMethodByteSignedParametersignedByteParam;
        [SerializeField] private Byte TestMethodByteUnsignedParameterunsignedByteParam;
        [SerializeField] private SByte TestMethodByteParametersignedByteParam;
        [SerializeField] private Byte TestMethodByteParameterunsignedByteParam;
        #endregion //TestInterfaceByteParameter Parameters

        #region TestInterfaceCharParameter Parameters
        private bool foldoutToggleTestInterfaceCharParameter = false;
        [SerializeField] private Char TestMethodCharParametercharParam;
        #endregion //TestInterfaceCharParameter Parameters

        #region TestInterfaceClassParameter Parameters
        private bool foldoutToggleTestInterfaceClassParameter = false;
        [SerializeField] private TestClass TestMethodClassParameterclassPrameter;
        #endregion //TestInterfaceClassParameter Parameters

        #region TestInterfaceDoubleParameter Parameters
        private bool foldoutToggleTestInterfaceDoubleParameter = false;
        [SerializeField] private Double TestMethodDoubleParameterdoubleParam;
        #endregion //TestInterfaceDoubleParameter Parameters

        #region TestInterfaceEnumParameter Parameters
        private bool foldoutToggleTestInterfaceEnumParameter = false;
        [SerializeField] private TestEnum TestMethodEnumParameterenumParam;
        #endregion //TestInterfaceEnumParameter Parameters

        #region TestInterfaceFloatParameter Parameters
        private bool foldoutToggleTestInterfaceFloatParameter = false;
        [SerializeField] private Single TestMethodFloatParameterfloatParam;
        #endregion //TestInterfaceFloatParameter Parameters

        #region TestInterfaceGameObjectParameter Parameters
        private bool foldoutToggleTestInterfaceGameObjectParameter = false;
        [SerializeField] private GameObject TestMethodGameObjectParametergameObjectParameter;
        #endregion //TestInterfaceGameObjectParameter Parameters

        #region TestInterfaceIntParameter Parameters
        private bool foldoutToggleTestInterfaceIntParameter = false;
        [SerializeField] private Int32 TestMethodIntSignedParametersignedIntParam;
        [SerializeField] private UInt32 TestMethodIntUnsignedParameterunsignedIntParam;
        [SerializeField] private Int32 TestMethodIntParametersignedIntParam;
        [SerializeField] private UInt32 TestMethodIntParameterunsignedIntParam;
        #endregion //TestInterfaceIntParameter Parameters

        #region TestInterfaceLongParameter Parameters
        private bool foldoutToggleTestInterfaceLongParameter = false;
        [SerializeField] private Int64 TestMethodLongSignedParametersignedLongParam;
        [SerializeField] private UInt64 TestMethodLongUnsignedParameterunsignedLongParam;
        [SerializeField] private Int64 TestMethodLongParametersignedLongParam;
        [SerializeField] private UInt64 TestMethodLongParameterunsignedLongParam;
        #endregion //TestInterfaceLongParameter Parameters

        #region TestInterfaceMonoBehaviourParameter Parameters
        private bool foldoutToggleTestInterfaceMonoBehaviourParameter = false;
        [SerializeField] private MonoBehaviour TestMethodMonoBehaviourParametermonoBehaviourParameter;
        #endregion //TestInterfaceMonoBehaviourParameter Parameters

        #region TestInterfaceNoParameter Parameters
        private bool foldoutToggleTestInterfaceNoParameter = false;
        #endregion //TestInterfaceNoParameter Parameters

        #region TestInterfaceOddBehaviourParameter Parameters
        private bool foldoutToggleTestInterfaceOddBehaviourParameter = false;
        [SerializeField] private OddBehaviour TestMethodOddBehaviourParameteroddBehaviourParameter;
        #endregion //TestInterfaceOddBehaviourParameter Parameters

        #region TestInterfaceOddBehaviourSingletonParameter Parameters
        private bool foldoutToggleTestInterfaceOddBehaviourSingletonParameter = false;
        [SerializeField] private TestClassOddBehaviourSingleton TestMethodOddBehaviourSingletonParameteroddBehaviourSingletonParameter;
        #endregion //TestInterfaceOddBehaviourSingletonParameter Parameters

        #region TestInterfaceOddScriptableObjectParameter Parameters
        private bool foldoutToggleTestInterfaceOddScriptableObjectParameter = false;
        [SerializeField] private OddScriptableObject TestMethodOddScriptableObjectParameteroddScriptableObjectParameter;
        #endregion //TestInterfaceOddScriptableObjectParameter Parameters

        #region TestInterfaceOddScriptableObjectSingletonParameter Parameters
        private bool foldoutToggleTestInterfaceOddScriptableObjectSingletonParameter = false;
        [SerializeField] private TestClassOddScriptableObjectSingle TestMethodOddScriptableObjectSingletonParameteroddScriptableObjectSingletonParameter;
        #endregion //TestInterfaceOddScriptableObjectSingletonParameter Parameters

        #region TestInterfaceQuaternionParameter Parameters
        private bool foldoutToggleTestInterfaceQuaternionParameter = false;
        [SerializeField] private Quaternion TestMethodQuaternionParameterquaternionParam;
        #endregion //TestInterfaceQuaternionParameter Parameters

        #region TestInterfaceScriptableObjectParameter Parameters
        private bool foldoutToggleTestInterfaceScriptableObjectParameter = false;
        [SerializeField] private ScriptableObject TestMethodScriptableObjectParameterscriptableObjectParameter;
        #endregion //TestInterfaceScriptableObjectParameter Parameters

        #region TestInterfaceShortParaeter Parameters
        private bool foldoutToggleTestInterfaceShortParaeter = false;
        [SerializeField] private Int16 TestMethodShortSignedParametersignedShortParam;
        [SerializeField] private UInt16 TestMethodShortUnsignedParameterunsignedShortParam;
        [SerializeField] private Int16 TestMethodShortParametersignedShortParam;
        [SerializeField] private UInt16 TestMethodShortParameterunsignedShortParam;
        #endregion //TestInterfaceShortParaeter Parameters

        #region TestInterfaceStringParameter Parameters
        private bool foldoutToggleTestInterfaceStringParameter = false;
        [SerializeField] private String TestMethodStringParameterstringParam;
        #endregion //TestInterfaceStringParameter Parameters

        #region TestInterfaceStructParameter Parameters
        private bool foldoutToggleTestInterfaceStructParameter = false;
        [SerializeField] private TestStruct TestMethodStructParameterstructParam;
        #endregion //TestInterfaceStructParameter Parameters

        #region TestInterfaceUnityEngineObjectParameter Parameters
        private bool foldoutToggleTestInterfaceUnityEngineObjectParameter = false;
        [SerializeField] private UnityEngine.Object TestMethodUnityEngineObjectParameterunityEngineObjectParameter;
        #endregion //TestInterfaceUnityEngineObjectParameter Parameters

        #region TestInterfaceVectorParameter Parameters
        private bool foldoutToggleTestInterfaceVectorParameter = false;
        [SerializeField] private Vector2 TestMethodVector2Parametervector2Param;
        [SerializeField] private Vector3 TestMethodVector3Parametervector3Param;
        [SerializeField] private Vector4 TestMethodVector4Parametervector4Param;
        [SerializeField] private Vector2Int TestMethodVector2IntParametervector2IntParam;
        [SerializeField] private Vector3Int TestMethodVector3IntParametervector3IntParam;
        #endregion //TestInterfaceVectorParameter Parameters

        #region TestInterfaceArrayParameter Parameters
        private bool foldoutToggleTestInterfaceArrayParameter = false;
        [SerializeField] private Int32[] TestMethodIntArrayParameterarrayParam;
        #endregion //TestInterfaceArrayParameter Parameters

        #region TestInterfaceInNamespace Parameters
        private bool foldoutToggleTestInterfaceInNamespace = false;
        [SerializeField] private TestClassWithNamespace.TestClassWithNamespaceEnum TestMethodInNamespaceNamespacedParametertestClassWithNamespaceEnum;
        [SerializeField] private TestClassNoNamespace.TestClassNoNamespaceEnum TestMethodInNamespaceRegularParametertestClassNoNamespaceEnum;
        #endregion //TestInterfaceInNamespace Parameters

        #endregion //Message Parameters
        #endregion //Private
        #endregion //Fields

        #region Methods
        #region Unity Messages
        private void OnEnable()
        {
            this.guiScrollPosition = Vector2.zero;
        }

        private void OnGUI()
        {
            SerializedObject serializedEditorWindow = new SerializedObject(this as ScriptableObject);
            this.guiScrollPosition = EditorGUILayout.BeginScrollView(this.guiScrollPosition);
            MessagingManager messagingManager = GameObject.FindObjectOfType<MessagingManager>();

            this.foldoutToggleTestInterfaceInheritance = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceInheritance, "TestInterfaceInheritance");
            if(this.foldoutToggleTestInterfaceInheritance)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceInheritance", MessageType.Info);
                SerializedProperty serialized_TestMethodInheritancequaternionParam = serializedEditorWindow.FindProperty("TestMethodInheritancequaternionParam");
                EditorGUILayout.PropertyField(serialized_TestMethodInheritancequaternionParam, new GUIContent("quaternionParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodInheritance Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodInheritanceEvent(this.TestMethodInheritancequaternionParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceNoNamespace = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceNoNamespace, "TestInterfaceNoNamespace");
            if(this.foldoutToggleTestInterfaceNoNamespace)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceNoNamespace", MessageType.Info);
                SerializedProperty serialized_TestMethodNoNamespaceNamespacedParametertestClassWithNamespaceEnum = serializedEditorWindow.FindProperty("TestMethodNoNamespaceNamespacedParametertestClassWithNamespaceEnum");
                EditorGUILayout.PropertyField(serialized_TestMethodNoNamespaceNamespacedParametertestClassWithNamespaceEnum, new GUIContent("testClassWithNamespaceEnum"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodNoNamespaceNamespacedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodNoNamespaceNamespacedParameterEvent(this.TestMethodNoNamespaceNamespacedParametertestClassWithNamespaceEnum);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodNoNamespaceRegularParametertestClassNoNamespaceEnum = serializedEditorWindow.FindProperty("TestMethodNoNamespaceRegularParametertestClassNoNamespaceEnum");
                EditorGUILayout.PropertyField(serialized_TestMethodNoNamespaceRegularParametertestClassNoNamespaceEnum, new GUIContent("testClassNoNamespaceEnum"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodNoNamespaceRegularParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodNoNamespaceRegularParameterEvent(this.TestMethodNoNamespaceRegularParametertestClassNoNamespaceEnum);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceBoolParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceBoolParameter, "TestInterfaceBoolParameter");
            if(this.foldoutToggleTestInterfaceBoolParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceBoolParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodBoolParameterboolParam = serializedEditorWindow.FindProperty("TestMethodBoolParameterboolParam");
                EditorGUILayout.PropertyField(serialized_TestMethodBoolParameterboolParam, new GUIContent("boolParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodBoolParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodBoolParameterEvent(this.TestMethodBoolParameterboolParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceByteParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceByteParameter, "TestInterfaceByteParameter");
            if(this.foldoutToggleTestInterfaceByteParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceByteParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodByteSignedParametersignedByteParam = serializedEditorWindow.FindProperty("TestMethodByteSignedParametersignedByteParam");
                EditorGUILayout.PropertyField(serialized_TestMethodByteSignedParametersignedByteParam, new GUIContent("signedByteParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodByteSignedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodByteSignedParameterEvent(this.TestMethodByteSignedParametersignedByteParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodByteUnsignedParameterunsignedByteParam = serializedEditorWindow.FindProperty("TestMethodByteUnsignedParameterunsignedByteParam");
                EditorGUILayout.PropertyField(serialized_TestMethodByteUnsignedParameterunsignedByteParam, new GUIContent("unsignedByteParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodByteUnsignedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodByteUnsignedParameterEvent(this.TestMethodByteUnsignedParameterunsignedByteParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodByteParametersignedByteParam = serializedEditorWindow.FindProperty("TestMethodByteParametersignedByteParam");
                EditorGUILayout.PropertyField(serialized_TestMethodByteParametersignedByteParam, new GUIContent("signedByteParam"), true);;
                SerializedProperty serialized_TestMethodByteParameterunsignedByteParam = serializedEditorWindow.FindProperty("TestMethodByteParameterunsignedByteParam");
                EditorGUILayout.PropertyField(serialized_TestMethodByteParameterunsignedByteParam, new GUIContent("unsignedByteParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodByteParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodByteParameterEvent(this.TestMethodByteParametersignedByteParam,this.TestMethodByteParameterunsignedByteParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceCharParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceCharParameter, "TestInterfaceCharParameter");
            if(this.foldoutToggleTestInterfaceCharParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceCharParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodCharParametercharParam = serializedEditorWindow.FindProperty("TestMethodCharParametercharParam");
                EditorGUILayout.PropertyField(serialized_TestMethodCharParametercharParam, new GUIContent("charParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodCharParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodCharParameterEvent(this.TestMethodCharParametercharParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceClassParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceClassParameter, "TestInterfaceClassParameter");
            if(this.foldoutToggleTestInterfaceClassParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceClassParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodClassParameterclassPrameter = serializedEditorWindow.FindProperty("TestMethodClassParameterclassPrameter");
                EditorGUILayout.PropertyField(serialized_TestMethodClassParameterclassPrameter, new GUIContent("classPrameter"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodClassParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodClassParameterEvent(this.TestMethodClassParameterclassPrameter);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceDoubleParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceDoubleParameter, "TestInterfaceDoubleParameter");
            if(this.foldoutToggleTestInterfaceDoubleParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceDoubleParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodDoubleParameterdoubleParam = serializedEditorWindow.FindProperty("TestMethodDoubleParameterdoubleParam");
                EditorGUILayout.PropertyField(serialized_TestMethodDoubleParameterdoubleParam, new GUIContent("doubleParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodDoubleParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodDoubleParameterEvent(this.TestMethodDoubleParameterdoubleParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceEnumParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceEnumParameter, "TestInterfaceEnumParameter");
            if(this.foldoutToggleTestInterfaceEnumParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceEnumParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodEnumParameterenumParam = serializedEditorWindow.FindProperty("TestMethodEnumParameterenumParam");
                EditorGUILayout.PropertyField(serialized_TestMethodEnumParameterenumParam, new GUIContent("enumParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodEnumParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodEnumParameterEvent(this.TestMethodEnumParameterenumParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceFloatParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceFloatParameter, "TestInterfaceFloatParameter");
            if(this.foldoutToggleTestInterfaceFloatParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceFloatParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodFloatParameterfloatParam = serializedEditorWindow.FindProperty("TestMethodFloatParameterfloatParam");
                EditorGUILayout.PropertyField(serialized_TestMethodFloatParameterfloatParam, new GUIContent("floatParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodFloatParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodFloatParameterEvent(this.TestMethodFloatParameterfloatParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceGameObjectParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceGameObjectParameter, "TestInterfaceGameObjectParameter");
            if(this.foldoutToggleTestInterfaceGameObjectParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceGameObjectParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodGameObjectParametergameObjectParameter = serializedEditorWindow.FindProperty("TestMethodGameObjectParametergameObjectParameter");
                EditorGUILayout.PropertyField(serialized_TestMethodGameObjectParametergameObjectParameter, new GUIContent("gameObjectParameter"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodGameObjectParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodGameObjectParameterEvent(this.TestMethodGameObjectParametergameObjectParameter);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceIntParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceIntParameter, "TestInterfaceIntParameter");
            if(this.foldoutToggleTestInterfaceIntParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceIntParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodIntSignedParametersignedIntParam = serializedEditorWindow.FindProperty("TestMethodIntSignedParametersignedIntParam");
                EditorGUILayout.PropertyField(serialized_TestMethodIntSignedParametersignedIntParam, new GUIContent("signedIntParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodIntSignedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodIntSignedParameterEvent(this.TestMethodIntSignedParametersignedIntParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodIntUnsignedParameterunsignedIntParam = serializedEditorWindow.FindProperty("TestMethodIntUnsignedParameterunsignedIntParam");
                EditorGUILayout.PropertyField(serialized_TestMethodIntUnsignedParameterunsignedIntParam, new GUIContent("unsignedIntParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodIntUnsignedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodIntUnsignedParameterEvent(this.TestMethodIntUnsignedParameterunsignedIntParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodIntParametersignedIntParam = serializedEditorWindow.FindProperty("TestMethodIntParametersignedIntParam");
                EditorGUILayout.PropertyField(serialized_TestMethodIntParametersignedIntParam, new GUIContent("signedIntParam"), true);;
                SerializedProperty serialized_TestMethodIntParameterunsignedIntParam = serializedEditorWindow.FindProperty("TestMethodIntParameterunsignedIntParam");
                EditorGUILayout.PropertyField(serialized_TestMethodIntParameterunsignedIntParam, new GUIContent("unsignedIntParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodIntParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodIntParameterEvent(this.TestMethodIntParametersignedIntParam,this.TestMethodIntParameterunsignedIntParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceLongParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceLongParameter, "TestInterfaceLongParameter");
            if(this.foldoutToggleTestInterfaceLongParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceLongParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodLongSignedParametersignedLongParam = serializedEditorWindow.FindProperty("TestMethodLongSignedParametersignedLongParam");
                EditorGUILayout.PropertyField(serialized_TestMethodLongSignedParametersignedLongParam, new GUIContent("signedLongParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodLongSignedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodLongSignedParameterEvent(this.TestMethodLongSignedParametersignedLongParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodLongUnsignedParameterunsignedLongParam = serializedEditorWindow.FindProperty("TestMethodLongUnsignedParameterunsignedLongParam");
                EditorGUILayout.PropertyField(serialized_TestMethodLongUnsignedParameterunsignedLongParam, new GUIContent("unsignedLongParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodLongUnsignedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodLongUnsignedParameterEvent(this.TestMethodLongUnsignedParameterunsignedLongParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodLongParametersignedLongParam = serializedEditorWindow.FindProperty("TestMethodLongParametersignedLongParam");
                EditorGUILayout.PropertyField(serialized_TestMethodLongParametersignedLongParam, new GUIContent("signedLongParam"), true);;
                SerializedProperty serialized_TestMethodLongParameterunsignedLongParam = serializedEditorWindow.FindProperty("TestMethodLongParameterunsignedLongParam");
                EditorGUILayout.PropertyField(serialized_TestMethodLongParameterunsignedLongParam, new GUIContent("unsignedLongParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodLongParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodLongParameterEvent(this.TestMethodLongParametersignedLongParam,this.TestMethodLongParameterunsignedLongParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceMonoBehaviourParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceMonoBehaviourParameter, "TestInterfaceMonoBehaviourParameter");
            if(this.foldoutToggleTestInterfaceMonoBehaviourParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceMonoBehaviourParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodMonoBehaviourParametermonoBehaviourParameter = serializedEditorWindow.FindProperty("TestMethodMonoBehaviourParametermonoBehaviourParameter");
                EditorGUILayout.PropertyField(serialized_TestMethodMonoBehaviourParametermonoBehaviourParameter, new GUIContent("monoBehaviourParameter"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodMonoBehaviourParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodMonoBehaviourParameterEvent(this.TestMethodMonoBehaviourParametermonoBehaviourParameter);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceNoParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceNoParameter, "TestInterfaceNoParameter");
            if(this.foldoutToggleTestInterfaceNoParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceNoParameter", MessageType.Info);
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodNoParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodNoParameterEvent();
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceOddBehaviourParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceOddBehaviourParameter, "TestInterfaceOddBehaviourParameter");
            if(this.foldoutToggleTestInterfaceOddBehaviourParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceOddBehaviourParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodOddBehaviourParameteroddBehaviourParameter = serializedEditorWindow.FindProperty("TestMethodOddBehaviourParameteroddBehaviourParameter");
                EditorGUILayout.PropertyField(serialized_TestMethodOddBehaviourParameteroddBehaviourParameter, new GUIContent("oddBehaviourParameter"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodOddBehaviourParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodOddBehaviourParameterEvent(this.TestMethodOddBehaviourParameteroddBehaviourParameter);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceOddBehaviourSingletonParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceOddBehaviourSingletonParameter, "TestInterfaceOddBehaviourSingletonParameter");
            if(this.foldoutToggleTestInterfaceOddBehaviourSingletonParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceOddBehaviourSingletonParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodOddBehaviourSingletonParameteroddBehaviourSingletonParameter = serializedEditorWindow.FindProperty("TestMethodOddBehaviourSingletonParameteroddBehaviourSingletonParameter");
                EditorGUILayout.PropertyField(serialized_TestMethodOddBehaviourSingletonParameteroddBehaviourSingletonParameter, new GUIContent("oddBehaviourSingletonParameter"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodOddBehaviourSingletonParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodOddBehaviourSingletonParameterEvent(this.TestMethodOddBehaviourSingletonParameteroddBehaviourSingletonParameter);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceOddScriptableObjectParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceOddScriptableObjectParameter, "TestInterfaceOddScriptableObjectParameter");
            if(this.foldoutToggleTestInterfaceOddScriptableObjectParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceOddScriptableObjectParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodOddScriptableObjectParameteroddScriptableObjectParameter = serializedEditorWindow.FindProperty("TestMethodOddScriptableObjectParameteroddScriptableObjectParameter");
                EditorGUILayout.PropertyField(serialized_TestMethodOddScriptableObjectParameteroddScriptableObjectParameter, new GUIContent("oddScriptableObjectParameter"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodOddScriptableObjectParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodOddScriptableObjectParameterEvent(this.TestMethodOddScriptableObjectParameteroddScriptableObjectParameter);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceOddScriptableObjectSingletonParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceOddScriptableObjectSingletonParameter, "TestInterfaceOddScriptableObjectSingletonParameter");
            if(this.foldoutToggleTestInterfaceOddScriptableObjectSingletonParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceOddScriptableObjectSingletonParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodOddScriptableObjectSingletonParameteroddScriptableObjectSingletonParameter = serializedEditorWindow.FindProperty("TestMethodOddScriptableObjectSingletonParameteroddScriptableObjectSingletonParameter");
                EditorGUILayout.PropertyField(serialized_TestMethodOddScriptableObjectSingletonParameteroddScriptableObjectSingletonParameter, new GUIContent("oddScriptableObjectSingletonParameter"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodOddScriptableObjectSingletonParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodOddScriptableObjectSingletonParameterEvent(this.TestMethodOddScriptableObjectSingletonParameteroddScriptableObjectSingletonParameter);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceQuaternionParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceQuaternionParameter, "TestInterfaceQuaternionParameter");
            if(this.foldoutToggleTestInterfaceQuaternionParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceQuaternionParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodQuaternionParameterquaternionParam = serializedEditorWindow.FindProperty("TestMethodQuaternionParameterquaternionParam");
                EditorGUILayout.PropertyField(serialized_TestMethodQuaternionParameterquaternionParam, new GUIContent("quaternionParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodQuaternionParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodQuaternionParameterEvent(this.TestMethodQuaternionParameterquaternionParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceScriptableObjectParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceScriptableObjectParameter, "TestInterfaceScriptableObjectParameter");
            if(this.foldoutToggleTestInterfaceScriptableObjectParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceScriptableObjectParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodScriptableObjectParameterscriptableObjectParameter = serializedEditorWindow.FindProperty("TestMethodScriptableObjectParameterscriptableObjectParameter");
                EditorGUILayout.PropertyField(serialized_TestMethodScriptableObjectParameterscriptableObjectParameter, new GUIContent("scriptableObjectParameter"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodScriptableObjectParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodScriptableObjectParameterEvent(this.TestMethodScriptableObjectParameterscriptableObjectParameter);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceShortParaeter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceShortParaeter, "TestInterfaceShortParaeter");
            if(this.foldoutToggleTestInterfaceShortParaeter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceShortParaeter", MessageType.Info);
                SerializedProperty serialized_TestMethodShortSignedParametersignedShortParam = serializedEditorWindow.FindProperty("TestMethodShortSignedParametersignedShortParam");
                EditorGUILayout.PropertyField(serialized_TestMethodShortSignedParametersignedShortParam, new GUIContent("signedShortParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodShortSignedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodShortSignedParameterEvent(this.TestMethodShortSignedParametersignedShortParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodShortUnsignedParameterunsignedShortParam = serializedEditorWindow.FindProperty("TestMethodShortUnsignedParameterunsignedShortParam");
                EditorGUILayout.PropertyField(serialized_TestMethodShortUnsignedParameterunsignedShortParam, new GUIContent("unsignedShortParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodShortUnsignedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodShortUnsignedParameterEvent(this.TestMethodShortUnsignedParameterunsignedShortParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodShortParametersignedShortParam = serializedEditorWindow.FindProperty("TestMethodShortParametersignedShortParam");
                EditorGUILayout.PropertyField(serialized_TestMethodShortParametersignedShortParam, new GUIContent("signedShortParam"), true);;
                SerializedProperty serialized_TestMethodShortParameterunsignedShortParam = serializedEditorWindow.FindProperty("TestMethodShortParameterunsignedShortParam");
                EditorGUILayout.PropertyField(serialized_TestMethodShortParameterunsignedShortParam, new GUIContent("unsignedShortParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodShortParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodShortParameterEvent(this.TestMethodShortParametersignedShortParam,this.TestMethodShortParameterunsignedShortParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceStringParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceStringParameter, "TestInterfaceStringParameter");
            if(this.foldoutToggleTestInterfaceStringParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceStringParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodStringParameterstringParam = serializedEditorWindow.FindProperty("TestMethodStringParameterstringParam");
                EditorGUILayout.PropertyField(serialized_TestMethodStringParameterstringParam, new GUIContent("stringParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodStringParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodStringParameterEvent(this.TestMethodStringParameterstringParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceStructParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceStructParameter, "TestInterfaceStructParameter");
            if(this.foldoutToggleTestInterfaceStructParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceStructParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodStructParameterstructParam = serializedEditorWindow.FindProperty("TestMethodStructParameterstructParam");
                EditorGUILayout.PropertyField(serialized_TestMethodStructParameterstructParam, new GUIContent("structParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodStructParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodStructParameterEvent(this.TestMethodStructParameterstructParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceUnityEngineObjectParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceUnityEngineObjectParameter, "TestInterfaceUnityEngineObjectParameter");
            if(this.foldoutToggleTestInterfaceUnityEngineObjectParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceUnityEngineObjectParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodUnityEngineObjectParameterunityEngineObjectParameter = serializedEditorWindow.FindProperty("TestMethodUnityEngineObjectParameterunityEngineObjectParameter");
                EditorGUILayout.PropertyField(serialized_TestMethodUnityEngineObjectParameterunityEngineObjectParameter, new GUIContent("unityEngineObjectParameter"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodUnityEngineObjectParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodUnityEngineObjectParameterEvent(this.TestMethodUnityEngineObjectParameterunityEngineObjectParameter);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceVectorParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceVectorParameter, "TestInterfaceVectorParameter");
            if(this.foldoutToggleTestInterfaceVectorParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceVectorParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodVector2Parametervector2Param = serializedEditorWindow.FindProperty("TestMethodVector2Parametervector2Param");
                EditorGUILayout.PropertyField(serialized_TestMethodVector2Parametervector2Param, new GUIContent("vector2Param"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodVector2Parameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodVector2ParameterEvent(this.TestMethodVector2Parametervector2Param);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodVector3Parametervector3Param = serializedEditorWindow.FindProperty("TestMethodVector3Parametervector3Param");
                EditorGUILayout.PropertyField(serialized_TestMethodVector3Parametervector3Param, new GUIContent("vector3Param"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodVector3Parameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodVector3ParameterEvent(this.TestMethodVector3Parametervector3Param);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodVector4Parametervector4Param = serializedEditorWindow.FindProperty("TestMethodVector4Parametervector4Param");
                EditorGUILayout.PropertyField(serialized_TestMethodVector4Parametervector4Param, new GUIContent("vector4Param"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodVector4Parameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodVector4ParameterEvent(this.TestMethodVector4Parametervector4Param);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodVector2IntParametervector2IntParam = serializedEditorWindow.FindProperty("TestMethodVector2IntParametervector2IntParam");
                EditorGUILayout.PropertyField(serialized_TestMethodVector2IntParametervector2IntParam, new GUIContent("vector2IntParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodVector2IntParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodVector2IntParameterEvent(this.TestMethodVector2IntParametervector2IntParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodVector3IntParametervector3IntParam = serializedEditorWindow.FindProperty("TestMethodVector3IntParametervector3IntParam");
                EditorGUILayout.PropertyField(serialized_TestMethodVector3IntParametervector3IntParam, new GUIContent("vector3IntParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodVector3IntParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodVector3IntParameterEvent(this.TestMethodVector3IntParametervector3IntParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceArrayParameter = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceArrayParameter, "TestInterfaceArrayParameter");
            if(this.foldoutToggleTestInterfaceArrayParameter)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceArrayParameter", MessageType.Info);
                SerializedProperty serialized_TestMethodIntArrayParameterarrayParam = serializedEditorWindow.FindProperty("TestMethodIntArrayParameterarrayParam");
                EditorGUILayout.PropertyField(serialized_TestMethodIntArrayParameterarrayParam, new GUIContent("arrayParam"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodIntArrayParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodIntArrayParameterEvent(this.TestMethodIntArrayParameterarrayParam);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleTestInterfaceInNamespace = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleTestInterfaceInNamespace, "TestInterfaceInNamespace");
            if(this.foldoutToggleTestInterfaceInNamespace)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("TestInterfaceInNamespace", MessageType.Info);
                SerializedProperty serialized_TestMethodInNamespaceNamespacedParametertestClassWithNamespaceEnum = serializedEditorWindow.FindProperty("TestMethodInNamespaceNamespacedParametertestClassWithNamespaceEnum");
                EditorGUILayout.PropertyField(serialized_TestMethodInNamespaceNamespacedParametertestClassWithNamespaceEnum, new GUIContent("testClassWithNamespaceEnum"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodInNamespaceNamespacedParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodInNamespaceNamespacedParameterEvent(this.TestMethodInNamespaceNamespacedParametertestClassWithNamespaceEnum);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                SerializedProperty serialized_TestMethodInNamespaceRegularParametertestClassNoNamespaceEnum = serializedEditorWindow.FindProperty("TestMethodInNamespaceRegularParametertestClassNoNamespaceEnum");
                EditorGUILayout.PropertyField(serialized_TestMethodInNamespaceRegularParametertestClassNoNamespaceEnum, new GUIContent("testClassNoNamespaceEnum"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire TestMethodInNamespaceRegularParameter Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.TestMethodInNamespaceRegularParameterEvent(this.TestMethodInNamespaceRegularParametertestClassNoNamespaceEnum);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanelGenerator)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            EditorGUILayout.EndScrollView();
            serializedEditorWindow.ApplyModifiedProperties();
        }
        #endregion //Unity Messages
        #endregion //Methods
    }
}
#endif //UNITY_EDITOR
