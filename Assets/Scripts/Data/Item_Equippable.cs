using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public enum EQUIPMENT_TYPE
    {
        HEAD,
        TORSO,
        HANDS,
        FEET,
        WEAPON_1,
        WEAPON_2,
        ACCESSORY_1,
        ACCESSORY_2
    }

    [CreateAssetMenu(fileName = "Item(Equippable)", menuName = "Sweet & Salty Studios/Item(Equippable)", order = 0)]
    public class Item_Equippable : Item
    {
        public EQUIPMENT_TYPE EQUIPMENT_TYPE;

        [Header("Stats")]
        public int Strenght_Bonus;
        public int Dexterityt_Bonus;
        public int Constitution_Bonus;
        public int Intelligence_Bonus;
        public int Wisdom_Bonus;
        public int Charisma_Bonus;
        [Space]
        public float Strenght_Percent_Bonus;
        public float Dexterityt_Percent_Bonus;
        public float Constitution_Percent_Bonus;
        public float Intelligence_Percent_Bonus;
        public float Wisdom_Percent_Bonus;
        public float Charisma_Percent_Bonus;
    }
}
