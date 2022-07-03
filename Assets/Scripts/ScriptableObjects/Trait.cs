using System;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Trait", menuName = "Items/NFT/New Trait", order = 1)]
    public class Trait : ScriptableObject
    {
        public TraitColor traitColor;
        public int value;
        public Sprite image;
    }
}