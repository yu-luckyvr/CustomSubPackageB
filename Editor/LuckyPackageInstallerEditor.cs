using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LuckyPackageInstaller))]
public class LuckyPackageInstallerEditor : Editor
{
    private LuckyPackageInstaller comp;
    private void OnEnable()
    {
        comp = (LuckyPackageInstaller) target;
    }

    public override void OnInspectorGUI()
    {
        comp.originalPath = EditorGUILayout.TextField("AssetBundle Path", comp.originalPath);
        string currentPath = AssetDatabase.GetAssetPath(comp);
        EditorGUILayout.TextField("Current Path",currentPath);
        
        if(GUILayout.Button("Install Package"))
        {
            comp.InstallLuckyPackage(currentPath);
        }
    }
    
    
}
