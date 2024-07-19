using Course.SOLID.After;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.SOLID
{
    public class ItemShield : Item
    {
        public override void ExecuteMessage()
        {
            Debug.Log($"{itemName}: Defense!");
        }
    }
}
