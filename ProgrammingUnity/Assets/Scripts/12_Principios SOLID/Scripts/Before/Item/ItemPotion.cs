using UnityEngine;

namespace Course.SOLID.Before
{
    public class ItemPotion : Item
    {
        public override void ExecuteMessage()
        {
            Debug.Log($"{itemName}: Drink to get more power!");

        }
    }
}