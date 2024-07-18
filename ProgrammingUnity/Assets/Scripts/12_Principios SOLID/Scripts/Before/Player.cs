using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Course.SOLID.Before
{
    public class Player : MonoBehaviour, IDamage, IHeal
    {
        public string playerName;
        public int health = 100;
        public Item currentItem;
        public UnityEvent<int> OnUpdateHealth;
        
        private IInteract otherCharacter;

        private void Start()
        {
            OnUpdateHealth.Invoke(health);
        }

        public void ActionInteracion()
        {
            if (otherCharacter != null)
            {
                otherCharacter.Interact();
            }
        }

        public void ActionConsumeItem()
        {
            if (currentItem != null)
            {
                if (currentItem is ItemWeapon)
                {
                    Debug.Log($"{currentItem.itemName}: Shoot!");
                }
                else if (currentItem is ItemPotion)
                {
                    Debug.Log($"{currentItem.itemName}: Drink to get more power!");
                }
            }
        }

        #region Interface

        public void Damage(int value)
        {
            health = Mathf.Clamp(health - value, 0, 100);

            if (health <= 0)
            {
                Debug.Log("Player DEAD");
            }

            OnUpdateHealth.Invoke(health);
        }

        public void Heal(int value)
        {
            health = Mathf.Clamp(health + value, 0, 100);

            OnUpdateHealth.Invoke(health);
        }

        #endregion

        private void OnTriggerEnter(Collider other)
        {
            otherCharacter = other.GetComponent<IInteract>();
        }

        private void OnTriggerExit(Collider other)
        {
            otherCharacter = null;
        }

    }
}