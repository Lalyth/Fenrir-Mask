using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace FenrirMask.Customs.PlayerCosmetics
{
    public class FenrirMask : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "FenrirMask";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("FenrirMask").AssignMaterialsByNames();
        public override bool BlockHats => true;

        public override void OnRegister(PlayerCosmetic gameDataObject)
        {
            PlayerOutfitComponent playerOutfitComponent = gameDataObject.Visual.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Fenrir Mask").GetComponent<SkinnedMeshRenderer>());
        }
    }
}