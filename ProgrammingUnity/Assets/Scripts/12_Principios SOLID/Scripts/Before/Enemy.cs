using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.Before
{
    public class Enemy : MonoBehaviour, IDamage
    {
        public string enemyName;

        public void Damage(int value)
        {
            Debug.Log($"Enemy receive {value} damage!");
        }

        private void OnTriggerEnter(Collider other)
        {
            IDamage otherCharacter = other.GetComponent<IDamage>();

            if (otherCharacter != null)
            {
                otherCharacter.Damage(15);
            }
        }

    }
}
