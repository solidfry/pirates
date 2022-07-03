using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName="Items/NFT/New NFTData")]
    public class NftData : ItemType
    {
        public List<Accessory> accessories = new();
        public List<Body> bodies = new();
        public List<Face> faces = new();
        public List<Background> backgrounds = new();
        public List<TraitColor> colors = new();
    }
}