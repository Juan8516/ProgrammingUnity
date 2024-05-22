using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Funciones : MonoBehaviour
    {
        int amount;
        private void Start()
        {
            //Do something
            //Called funtion
            Shoot(10);
            Shoot(weaponType: 8);

            int myId;
            myId = GetPlayerId();
            ChangePlayerIdWithOut(out myId); //20
            ChangePlayerIdWithRef(ref myId); //30
        }

        private void Shoot(int amountBullets = 5, int weaponType = 0)//Assignment Parameter
        {
            //Do something
            amount -= amountBullets;
        }

        private void ChangePlayerIdWithOut(out int id)
        {
            id = 20;
        }

        private void ChangePlayerIdWithRef(ref int id)
        {
            id = 30;
        }

        private int GetPlayerId() //return values
        {
            return 10;
        }
    }
}
