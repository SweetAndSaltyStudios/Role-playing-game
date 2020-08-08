using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    [CreateAssetMenu(fileName = "Item", menuName = "Sweet & Salty Studios/Item", order = 0)]
    public class Item : ScriptableObject
    {
        public string Name;
        public Sprite Icon;
    }
}
