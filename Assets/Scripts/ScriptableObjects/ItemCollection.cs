using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Item Collection", menuName = "Items/Item Collections", order = 0)]
    public class ItemCollection : ScriptableObject
    {
        // todo: when this event is called we update the UI
        public event Action Changed;
        [SerializeField] private List<ItemType> collectedItems;

        public int Count => collectedItems.Count;

        public void Add(Item item)
        {
            collectedItems.Add(item.ItemType);
            Changed?.Invoke();
        }

        private void OnDisable()
        {
            collectedItems.Clear();
        }

        public int CountOf(ItemType itemType)
        {
            return collectedItems.Count(t => t == itemType);
        }
    }
}