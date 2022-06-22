using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using OddCommon.Debug;
using UnityEngine;


namespace OddCommon.Messaging.Editor
{
    public class MessagingMenuItems
    {
        #region Class
        #region Methods
        #region Editor Menu Items
        [MenuItem("Messaging/Generate Messages Extensions", false, 8001)]
        internal static void GenerateMessageExtensionsFile()
        {
            bool filepathFound = false;
            bool fileFound = false;
            string className = nameof(MessagingMenuItems);
            string editorPrefsKey = MessagingUtilities.GetProjectUniqueHash128(MessagingConstants.messagingExtensionsFileName).ToString();
            string eventExtensionsRelativePath = EditorPrefs.GetString(editorPrefsKey, "");
            if ( !String.IsNullOrEmpty( eventExtensionsRelativePath ))
            {
                if( File.Exists( eventExtensionsRelativePath ) )
                {
                    filepathFound = true;
                    fileFound = true;
                    string fileFoundLogFormat = "[{0}] Existing {1} found; will overwrite.";
                    Logging.Log(fileFoundLogFormat, className, eventExtensionsRelativePath);   
                }
                else
                {
                    EditorPrefs.DeleteKey( editorPrefsKey );
                }
            } 
            if ( !fileFound )
            {
                filepathFound =
                    MessagingUtilities.GetSaveAssetPath
                    (
                        MessagingConstants.messagingExtensionsFileName,
                        ".cs",
                        out eventExtensionsRelativePath
                    );
            }
            if (filepathFound)
            {
                if (MessagingExtensionsGenerator.GenerateMessagingExtensions(eventExtensionsRelativePath, false))
                {
                    EditorPrefs.SetString( editorPrefsKey, eventExtensionsRelativePath );
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
        
        [MenuItem("Messaging/Generate Stubbed Messages Extensions", false, 8002)]
        internal static void GenerateStubbedMessageExtensionsFile()
        {
            bool filepathFound = false;
            bool fileFound = false;
            string className = nameof(MessagingMenuItems);
            string editorPrefsKey = MessagingUtilities.GetProjectUniqueHash128(MessagingConstants.messagingExtensionsFileName).ToString();
            string eventExtensionsRelativePath = EditorPrefs.GetString(editorPrefsKey,"");
            if ( !String.IsNullOrEmpty( eventExtensionsRelativePath ))
            {
                if( File.Exists( eventExtensionsRelativePath ) )
                {
                    filepathFound = true;
                    fileFound = true;
                    string fileFoundLogFormat = "[{0}] Existing {1} found; will overwrite.";
                    Logging.Log(fileFoundLogFormat, className, eventExtensionsRelativePath);   
                }
                else
                {
                    EditorPrefs.DeleteKey( editorPrefsKey );
                }
            } 
            if ( !fileFound )
            {
                filepathFound =
                    MessagingUtilities.GetSaveAssetPath
                    (
                        MessagingConstants.messagingExtensionsFileName,
                        ".cs",
                        out eventExtensionsRelativePath
                    );
            }
            if (filepathFound)
            {
                if (MessagingExtensionsGenerator.GenerateMessagingExtensions(eventExtensionsRelativePath, true))
                {
                    EditorPrefs.SetString( editorPrefsKey, eventExtensionsRelativePath );
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
        
        [MenuItem("Messaging/Generate Control Panel Editor file", false, 9001)]
        private static void GenerateControlPanel()
        {
            bool filepathFound = false;
            bool fileFound = false;
            string className = nameof(MessagingMenuItems);
            string editorPrefsKey = MessagingUtilities.GetProjectUniqueHash128(MessagingConstants.controlPanelScriptFilename).ToString();
            string controlPanelRelativePath = EditorPrefs.GetString(editorPrefsKey, "");
            if ( !String.IsNullOrEmpty( controlPanelRelativePath ))
            {
                if( File.Exists( controlPanelRelativePath ) )
                {
                    filepathFound = true;
                    fileFound = true;
                    string fileFoundLogFormat = "[{0}] Existing {1} found; will overwrite.";
                    Logging.Log(fileFoundLogFormat, className, controlPanelRelativePath);   
                }
                else
                {
                    EditorPrefs.DeleteKey( editorPrefsKey );
                }
            } 
            if ( !fileFound )
            {
                filepathFound =
                    MessagingUtilities.GetSaveAssetPath
                    (
                        MessagingConstants.controlPanelScriptFilename,
                        ".cs",
                        out controlPanelRelativePath
                    );
            }
            if (filepathFound)
            {
                List<string> controlPanelNamespaceAndTitle = 
                    MessagingUtilities.GetControlPanelNamespaceAndTitle(controlPanelRelativePath);
                if (string.IsNullOrEmpty(controlPanelNamespaceAndTitle[0]) ||
                    string.IsNullOrEmpty(controlPanelNamespaceAndTitle[1]))
                {
                    Logging.Error("[{0}] Please provide a control panel namespace and title.", className);
                    return;
                }
                bool generateControlPanelSucceeded =
                    MessagingControlPanelGenerator.GenerateControlPanel
                    (
                        controlPanelRelativePath,
                        controlPanelNamespaceAndTitle[0],
                        controlPanelNamespaceAndTitle[1]
                    );
                if (generateControlPanelSucceeded)
                {
                    EditorPrefs.SetString( editorPrefsKey, controlPanelRelativePath );
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