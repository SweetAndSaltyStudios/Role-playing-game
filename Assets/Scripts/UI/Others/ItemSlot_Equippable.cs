using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class ItemSlot_Equippable : ItemSlot
    {
        public EQUIPMENT_TYPE EQUIPMENT_TYPE;

        protected override void OnValidate()
        {
            base.OnValidate();
            gameObject.name = EQUIPMENT_TYPE.ToString() + " Slot";
        }
    }
}
