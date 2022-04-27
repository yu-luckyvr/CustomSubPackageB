using UnityEditor;
using UnityEngine;

namespace LuckyOS.Editor
{

    [CustomEditor(typeof(LuckyPackageInstaller))]
    public class LuckyPackageInstallerEditor : UnityEditor.Editor
    {
        private static LuckyPackageInstaller comp;
        private static string currentPath = null;

        private void OnEnable()
        {
            comp = (LuckyPackageInstaller) target;
        }
        
        private void OnDisable()
        {
            comp = null;
            currentPath = null;
        }
        

        public override void OnInspectorGUI()
        {
            comp.bundlePath = EditorGUILayout.TextField("AssetBundle Path", comp.bundlePath);
            
            currentPath = AssetDatabase.GetAssetPath(comp);
            int start_index = currentPath.Length - comp.name.Length - 6;
            currentPath = currentPath.Remove(start_index);
            currentPath += comp.bundlePath;
            EditorGUILayout.LabelField("Bundle Path", currentPath);
        }

        [MenuItem("LuckyOS/PackageInstaller/Copy Bundle Path")]
        public static void CopyPathMenu()
        {
            if (comp == null)
            {
                Debug.LogWarning("PackageInstall asset is not focused by inspector. Please first select a PackageInstall asset.");
            }
            else
            {
                Debug.LogWarning($"Copied to ClipBoard: BundlePath: {currentPath }");
                GUIUtility.systemCopyBuffer = currentPath;
            }

        }
    }
    
    
}
