using UnityEngine;

namespace Course.SOLID.Before
{
    public class ItemWeapon : Item
    {
        public override void ExecuteMessage()
        {
            Debug.Log($"{itemName}: Shoot!");
        }
    }
}