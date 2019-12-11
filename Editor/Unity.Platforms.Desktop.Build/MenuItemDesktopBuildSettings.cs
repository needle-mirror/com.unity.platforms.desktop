using System.IO;
using UnityEditor;
using Unity.Build;
using Unity.Platforms.Build;
using BuildPipeline = Unity.Build.BuildPipeline;

namespace Unity.Platforms.Desktop.Build
{
    internal static class MenuItemDesktopBuildSettings
    {
        internal static void CreateNewBuildSettingsAssetClassic(string pipelinePath)
        {
            var pipeline = AssetDatabase.LoadAssetAtPath<BuildPipeline>(pipelinePath);
            Selection.activeObject = MenuItemBuildSettings.CreateNewBuildSettingsAsset("Classic", new ClassicBuildProfile { Pipeline = pipeline });
        }
    }
}
