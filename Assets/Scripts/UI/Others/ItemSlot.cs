using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Sweet_And_Salty_Studios
{
    public class ItemSlot : UI_Element
    {
        [SerializeField] private Image image;

        public Item item;

        public Item Item
        {
            get 
            {
                return item;
            }
            set 
            {
                item = value;

                if(item == null)
                {
                    image.enabled = false;
                } 
                else
                {
                    image.sprite = item.Icon;
                    image.enabled = true;
                }
            }
        }

        protected virtual void OnValidate()
        {
            if(image == null)
            {
                image = GetComponent<Image>();
            }
        }
    }
}
