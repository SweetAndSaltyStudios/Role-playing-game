using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class EquipmentPanel : UI_Panel
    {
        [SerializeField] private Transform itemSlotContainer;
        [SerializeField] private ItemSlot_Equippable[] itemSlots;

        private void OnValidate()
        {
            if(itemSlotContainer != null)
            {
                itemSlots = itemSlotContainer.GetComponentsInChildren<ItemSlot_Equippable>();
            }
        }

        public bool AddItem(Item_Equippable item, out Item_Equippable previousItem)
        {
            for (int i = 0; i < itemSlots.Length; i++)
            {
                if(itemSlots[i].EQUIPMENT_TYPE == item.EQUIPMENT_TYPE)
                {
                    previousItem = (Item_Equippable)itemSlots[i].Item;
                    itemSlots[i].Item = item;
                    return true;
                }           
            }

            previousItem = null;
            return false;
        }

        public bool RemoveItem(Item_Equippable item)
        {
            for (int i = 0; i < itemSlots.Length; i++)
            {
                if (itemSlots[i].Item == item)
                {
                    itemSlots[i].Item = null;
                    return true;
                }
            }

            return false;
        }
    }

   
}