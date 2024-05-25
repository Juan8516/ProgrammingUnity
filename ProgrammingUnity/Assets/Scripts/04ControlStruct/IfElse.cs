using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.ControlStruct
{
    public class IfElse : MonoBehaviour
    {
        public bool canAttack;

        private void Attack()
        {
            //if / else
            if (canAttack)
            {
            }
            else
            {
                Debug.Log("I can't Attack");

            }

            //Operador Ternario
            Debug.Log(canAttack ? "Attack" : "I can't Attack");
            int id = canAttack ? 24 : 1;

            //En una linea
            if (canAttack) Debug.Log("Attack");

            if (canAttack)
                Debug.Log("Attack");
        }

        public int currentAmmo;
        public int totalAmmo;

        private void CheckAmmo()
        {
            //Comparando Valores
            if(currentAmmo > 0)
            {
                //Shoot
            }

            if(totalAmmo == 0 || currentAmmo <= 0) 
            {
                //Require ammo
            }
        }

        public SphereCollider shieldCollider;

        private void Defense()
        {
            //Code smell
            if(shieldCollider != null) 
            {
                //Use Shield
            }

            if (shieldCollider)
            {
                //Use Shield
            }
        }
        
    }
}
