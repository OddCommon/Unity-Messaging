#if UNITY_EDITOR


namespace OddCommon.Messaging.Editor
{
    public class MessagingConstants
    { 
        #region Static
        #region Fields
        internal static string defaultAssetsPath = "Assets";
        internal static string messagingExtensionsFileName = "MessagingExtensions";
        internal static string controlPanelScriptFilename = "MessagingControlPanel";
        internal static string controlPanelScriptNamespace = "Pixeltheory.Messaging.Editor";
        public static float controlPanelButtonsOffset = 18.0f;
        
        
        
        internal static string configAssetFileName = "MessagingConfig.asset";
        internal static string configAssetFilepathEditorWindowHelp =
            "Click on the 'Select Folder' button to select where to place the Messaging package config asset file.\n" +
            "Click on the 'Clear Path' button to delete the asset file and clear the current folder path.";
        internal static string configAssetFilepathEditorWindowWarning =
            "WARNING - If you clear the config asset folder path, the config asset will be deleted and you will lose your data!";
        internal static string configAssetFilepathSetWarning = 
            "[pixeltheory-unity-messaging] Current Messaging package config asset file location not valid! Please open " +
            "'Pixeltheory->Messaging->Config Panel' and select a location to put the config asset file.";
        internal static string configAssetFileMoveFailedWarning =
            "[pixeltheory-unity-messaging] Could not move Messaging package config asset file.";
        internal static string configAssetFilepathInvalidWarning =
            "[pixeltheory-unity-messaging] Invalid location for Messaging package config asset file location. Please try again. " +
            "You must pick a location inside the Assets folder.";
        
        internal static string messagingExtensionsFilepathEditorWindowHelp =
            "Click on the 'Select Folder' button to select where to place the Messaging extensions file.\n" +
            "Click on the 'Clear Path' button to delete the extensions file and clear the current folder path.";
        internal static string messagingExtensionsFilepathSetWarning = 
            "[pixeltheory-unity-messaging] - Current Messaging extensions file location not valid! Please open " +
            "'Pixeltheory->Messaging->Config Panel' and select a location to put the extensions file.";
        internal static string messagingExtensionsFileMoveFailedWarning =
            "[pixeltheory-unity-messaging] - Could not move Messaging extensions file.";
        internal static string messagingExtensionsFilepathInvalidWarning = 
            "[pixeltheory-unity-messaging] - Invalid Path for Messaging extensions file location. Please try again. " +
            "You must pick a location inside the Assets folder.";
        
        internal static string controlPanelScriptFilepathEditorWindowHelp =
            "Click on the 'Select Folder' button to select where to place the control panel (Editor script) file.\n" +
            "Click on the 'Clear Path' button to delete the control panel file and clear the current folder path.";
        internal static string controlPanelScriptFilepathSetWarning =
            "[pixeltheory-unity-messaging] - Current control panel file location not valid! Please open " +
            "'Pixeltheory->Messaging->Configuration Panel' and select a location to put the extensions file.";
        internal static string controlPanelScriptFilepathInvalidWarning =
            "[pixeltheory-unity-messaging] - Could not move control panel file.";
        internal static string controlPanelScriptFileMoveFailedWarning =
            "[pixeltheory-unity-messaging] - Invalid Path for control panel file location. Please try again. " +
            "You must pick a location inside the Assets folder.";
        #endregion //Fields
        #endregion //Static
    }
}
#endif //UNITY_EDITOR