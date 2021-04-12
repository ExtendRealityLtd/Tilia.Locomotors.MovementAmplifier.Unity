namespace Tilia.Locomotors.MovementAmplifier.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Locomotors/MovementAmplifier/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.locomotors.movementamplifier.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabMovementAmplifier = "Locomotors.MovementAmplifier";

        [MenuItem(menuItemRoot + prefabMovementAmplifier, false, priority)]
        private static void AddMovementAmplifier()
        {
            string prefab = prefabMovementAmplifier + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}