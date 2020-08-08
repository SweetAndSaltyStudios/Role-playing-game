using System.Collections.Generic;
using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class InventoryPanel : UI_Panel
    {
        [SerializeField] private Transform itemSlotContainer;
        [SerializeField] private ItemSlot[] itemSlots;
        [SerializeField] private List<Item> items = new List<Item>();

        private void OnValidate()
        {
            if(itemSlotContainer != null)
            {
                itemSlots = itemSlotContainer.GetComponentsInChildren<ItemSlot>();
            }

            RefreshUI();
        }

        private void RefreshUI()
        {
            var i = 0;

            for (; i < items.Count && i < itemSlots.Length; i++)
            {
                itemSlots[i].Item = items[i];
            }

            for (; i < itemSlots.Length; i++)
            {
                itemSlots[i].Item = null;
            }
        }

        public bool AddItem(Item item)
        {
            if (IsFull())
                return false;

            items.Add(item);
            RefreshUI();
            return true;
        }

        public bool RemoveItem(Item item)
        {
            if (items.Remove(item))
            {
                RefreshUI();
                return true;
            }

            return false;
        }

        private bool IsFull()
        {
            return items.Count >= itemSlots.Length;
        }
    }
}