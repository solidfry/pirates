using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Color-", menuName = "Items/NFT/New Trait Color", order = 1)]
    public class TraitColor : ScriptableObject
    {
        public Color color;
        public int value;
    }
}