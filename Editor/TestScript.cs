using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;

public class TestScript
{

    [MenuItem("Test/Test")]
    public static void DoThing()
    {
        Client.Add("https://github.com/JonathanLiuApp/TestUnityGithubPackage.git");
        string[] unusedFolder = { "Assets/Unused" };

        foreach (var asset in AssetDatabase.FindAssets("", unusedFolder))
        {
            var path = AssetDatabase.GUIDToAssetPath(asset);
            AssetDatabase.DeleteAsset(path);
        }
    }


}
