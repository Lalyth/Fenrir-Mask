using KitchenLib;
using KitchenLib.Logging.Exceptions;
using KitchenMods;
using System.Linq;
using System.Reflection;
using KitchenLib.Interfaces;
using UnityEngine;
using KitchenLogger = KitchenLib.Logging.KitchenLogger;

namespace FenrirMask
{
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.lalyth.fenrirmask";
        public const string MOD_NAME = "Fenrir Mask";
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = "Lalyth";
        public const string MOD_GAMEVERSION = ">=1.2.0";

        internal static AssetBundle Bundle;
        internal static KitchenLogger Logger;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        protected override void OnInitialise()
        {
            Logger.LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault() ?? throw new MissingAssetBundleException(MOD_GUID);
            Logger = InitLogger();
        }
    }
}