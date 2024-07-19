using UnityEngine;

namespace Course.SOLID.Before
{
    public abstract class Item : MonoBehaviour
    {
        public string itemName;

        public abstract void ExecuteMessage();
    }
}