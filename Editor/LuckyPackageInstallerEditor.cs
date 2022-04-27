using UnityEditor;
using UnityEngine;

namespace LuckyOS.Editor
{

    [CustomEditor(typeof(LuckyPackageInstaller))]
    public class LuckyPackageInstallerEditor : UnityEditor.Editor
    {
        private LuckyPackageInstaller comp;

        private void OnEnable()
        {
            comp = (LuckyPackageInstaller) target;
        }

        public override void OnInspectorGUI()
        {
            comp.bundlePath = EditorGUILayout.TextField("AssetBundle Path", comp.bundlePath);
            
            string currentPath = AssetDatabase.GetAssetPath(comp);
            int start_index = currentPath.Length - comp.name.Length - 6;
            currentPath = currentPath.Remove(start_index);
            currentPath += comp.bundlePath;
            EditorGUILayout.LabelField("Current Path", currentPath);

            if (GUILayout.Button("Copy to Clipboard"))
            {
                GUIUtility.systemCopyBuffer = currentPath;
            }
        }
    }
}
