using System;
using System.IO;
using System.Reflection;
using UnityEditor;
using OddCommon.Debug;


namespace OddCommon.Messaging.Editor
{
    public class MessagingMenuItems
    {
        #region Class
        #region Methods
        #region Editor Menu Items
        [MenuItem("OddCommon/Messaging/Messaging Control Panel", false, 0)]
        internal static void ControlPanelWindow()
        {
            string[] searchFolders = new string[] { MessagingConstants.defaultAssetsPath };
            string[] guids = AssetDatabase.FindAssets("MessagingControlPanel", searchFolders);
            char[] directorySeparators = new char[] {Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar};
            string cpEditorScriptFilenameFull = MessagingConstants.controlPanelScriptFilename + ".cs";
            string cpEditorScriptFullName = 
                MessagingConstants.controlPanelScriptNamespace + "." + MessagingConstants.controlPanelScriptFilename;
            if (guids != null && guids.Length != 0)
            {
                foreach (string guid in guids)
                {
                    string[] splitPath = AssetDatabase.GUIDToAssetPath(guid).Split(directorySeparators);
                    foreach (string pathPiece in splitPath)
                    {
                        if (pathPiece == cpEditorScriptFilenameFull)
                        {
                            // MessagingControlPanel.cs exists, use reflection to instantiate instance
                            // because we don't have a reference to wherever MessagingControlPanel.cs
                            // is in the project from this package.
                            Assembly[] currentAssemblies = AppDomain.CurrentDomain.GetAssemblies();
                            foreach (Assembly assembly in currentAssemblies)
                            {
                                Type controlPanelType = assembly.GetType(cpEditorScriptFullName);
                                if (controlPanelType != null)
                                {
                                    EditorWindow.GetWindow
                                    (
                                        controlPanelType,
                                        false,
                                        "Messaging Control Panel",
                                        true
                                    ).Show();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
        
        [MenuItem("OddCommon/Messaging/Generate Messages Extensions file", false, 1001)]
        internal static void GenerateMessageExtensionsFile()
        {
            string className = nameof(MessagingMenuItems);
            string eventExtensionsRelativePath = null;
            bool filepathFound =
                MessagingUtilities.GetSaveAssetPath
                (
                    MessagingConstants.messagingExtensionsFileName,
                    ".cs",
                    out eventExtensionsRelativePath
                );
            if (filepathFound)
            {
                if (MessagingExtensionsGenerator.GenerateMessagingExtensions(eventExtensionsRelativePath, false))
                {
                    Logging.Log("[{0}] Successfully generated MessagingExtensions.cs.", className);
                }
                else
                {
                    Logging.Error("[{0}] Error generating MessagingExtensions.cs; check console output.", className);
                }
            }
            else
            {
                string fileSelectErrorLogFormat =
                    "[{0}] Error finding/selecting filepath for MessagingExtensions.cs; check console output";
                Logging.Error(fileSelectErrorLogFormat, className);
            }
        }
        
        [MenuItem("OddCommon/Messaging/Generate Stubbed Messages Extensions file", false, 1002)]
        internal static void GenerateStubbedMessageExtensionsFile()
        {
            string className = nameof(MessagingMenuItems);
            string eventExtensionsRelativePath = null;
            bool filepathFound =
                MessagingUtilities.GetSaveAssetPath
                (
                    MessagingConstants.messagingExtensionsFileName,
                    ".cs",
                    out eventExtensionsRelativePath
                );
            if (filepathFound)
            {
                if (MessagingExtensionsGenerator.GenerateMessagingExtensions(eventExtensionsRelativePath, true))
                {
                    Logging.Log("[{0}] Successfully generated stubbed MessagingExtensions.cs.", className);
                }
                else
                {
                    string generateExtensionsStubErrorLogFormat =
                        "[{0}] Error generating stubbed MessagingExtensions.cs; check console output.";
                    Logging.Error(generateExtensionsStubErrorLogFormat, className);
                }
            }
            else
            {
                string fileSelectErrorLogFormat =
                    "[{0}] Error finding/selecting filepath for stubbed MessagingExtensions.cs; check console output";
                Logging.Error(fileSelectErrorLogFormat, className);
            }
        }
        
        [MenuItem("OddCommon/Messaging/Generate Control Panel Editor file", false, 1003)]
        private static void GenerateControlPanel()
        {
            string className = nameof(MessagingMenuItems);
            string controlPanelRelativePath = null;
            bool filepathFound =
                MessagingUtilities.GetSaveAssetPath
                (
                    MessagingConstants.controlPanelScriptFilename,
                    ".cs",
                    out controlPanelRelativePath
                );
            Logging.Log(controlPanelRelativePath);
            if (filepathFound)
            {
                if (MessagingControlPanelGenerator.GenerateControlPanel(controlPanelRelativePath))
                {
                    Logging.Log("[{0}] Successfully generated MessagingControlPanel.cs.", className);
                }
                else
                {
                    string generateControlPanelErrorLogFormat =
                        "[{0}] Error generating MessagingControlPanel.cs; check console output.";
                    Logging.Error(generateControlPanelErrorLogFormat, className);
                }
            }
            else
            {
                string fileSelectErrorLogFormat =
                    "[{0}] Error finding/selecting filepath for MessagingControlPanel.cs; check console output";
                Logging.Error(fileSelectErrorLogFormat, className);
            }
        }
        #endregion //Editor Menu Items
        #endregion //Methods
        #endregion //Class
    }
}