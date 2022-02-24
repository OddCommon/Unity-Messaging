#if UNITY_EDITOR
// MessagingControlPanelEditorWindow.cs
// Auto-Generated 5/22/2020 5:50:39 PM
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEditor;
using OddCommon.Messaging;


namespace OddCommon.Messaging.Editor
{
    public class MessagingControlPanelEditorWindow : EditorWindow
{
    #region Fields
    #region Inspector Fields
    private bool foldoutTestMethodThree = false;
    private int testMethodThreeInt;
    private float testMethodThreeFloat;
    private string testMethodThreeString;
    private bool foldoutTestMethodFour = false;
    private int testMethodFourTestStructX;
    private int testMethodFourTestStructY;
    #endregion //Inspector Fields
    #endregion //Fields
   
    private GameObject testObject;
    
    
    private void OnGUI()
    {
        this.foldoutTestMethodThree = EditorGUILayout.Foldout(this.foldoutTestMethodThree, "Test Method Three", true);
        if (this.foldoutTestMethodThree)
        {
            EditorGUILayout.BeginVertical();
            EditorGUI.indentLevel++;
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Test Method Three", EditorStyles.largeLabel);
            this.testMethodThreeInt = EditorGUILayout.IntField("Test Int", this.testMethodThreeInt);
            this.testMethodThreeFloat = EditorGUILayout.FloatField("Test Float", this.testMethodThreeFloat);
            this.testMethodThreeString = EditorGUILayout.TextField("Test String", this.testMethodThreeString);
            //this.testObject = (GameObject)EditorGUILayout.ObjectField("Test GameObject", (UnityEngine.Object)this.testObject, typeof(GameObject), true);
            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(EditorGUI.indentLevel * 15);
            if (GUILayout.Button("Fire Test Message"))
            {
                //MessagingManager.Instance.TestMethodThreeEvent(testMethodThreeInt, testMethodThreeFloat, testMethodThreeString);
            }
            EditorGUILayout.EndHorizontal();
            EditorGUI.indentLevel--;
            EditorGUILayout.EndVertical();
        }
        
        this.foldoutTestMethodFour = EditorGUILayout.Foldout(this.foldoutTestMethodFour, "Test Method Four", true);
        if (this.foldoutTestMethodFour)
        {
            EditorGUILayout.BeginVertical();
            EditorGUI.indentLevel++;
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Test Method Four", EditorStyles.largeLabel);
            EditorGUILayout.LabelField("TestStruct");
            EditorGUI.indentLevel++;
            this.testMethodFourTestStructX = EditorGUILayout.IntField("TestStruct X", this.testMethodFourTestStructX);
            this.testMethodFourTestStructY = EditorGUILayout.IntField("TestStruct Y", this.testMethodFourTestStructY);
            EditorGUI.indentLevel--;
            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(EditorGUI.indentLevel * 15);
            if (GUILayout.Button("Fire Test Message"))
            {
                //MessagingManager.Instance.TestMethodFourEvent(new TestStruct() { x = testMethodFourTestStructX, y = this.testMethodFourTestStructY});
            }
            EditorGUILayout.EndHorizontal();
            EditorGUI.indentLevel--;
            EditorGUILayout.EndVertical();
        }
    }

    #region TestInterfaceInheritanceChild
    #endregion

    #region TestInterfaceInheritanceParent
    #endregion

    #region TestInterfaceNestedParameterNoNamespace
    #endregion

    #region TestInterfaceNestedParameterWithNamespace
    #endregion
}
}
#endif