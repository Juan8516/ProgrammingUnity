using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Constructor : MonoBehaviour
    {
        // Constructores
        void Start()
        {
            weapon myWeapon = new weapon(100);
            myWeapon.Shoot();
        }
    }

    public class weapon
    {
        int ammo;

        public weapon()
        {
            ammo = 30;
        }

        public weapon(int ammo)
        {
            this.ammo = ammo;
        }

        public void Shoot()
        {

        }
    }
}
