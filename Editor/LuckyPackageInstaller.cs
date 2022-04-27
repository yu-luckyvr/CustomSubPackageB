using UnityEngine;

namespace LuckyOS.Editor
{
    [CreateAssetMenu(menuName = "LuckyOS/PackageInstaller", fileName = "PackageInstaller")]
    public class LuckyPackageInstaller : ScriptableObject
    {
        public string bundlePath = "AssetBundles~";
        public string bundleCatalog;
    }
}
