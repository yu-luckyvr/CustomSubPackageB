using UnityEngine;

namespace LuckyOS.Editor
{
    [CreateAssetMenu(menuName = "LuckyOS/PackageInstaller", fileName = "PackageInstaller")]
    [System.Serializable]
    public class LuckyPackageInstaller : ScriptableObject
    {
        public string bundlePath = "AssetBundles~";
        public string bundleCatalog;
    }
}
