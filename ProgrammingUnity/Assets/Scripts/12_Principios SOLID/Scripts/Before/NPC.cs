using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.Before
{
    public class NPC : MonoBehaviour, IInteract
    {
        public string npcName;
        private IHeal otherCharacter;


        public void Interact()
        {
            if (otherCharacter != null)
            {
                otherCharacter.Heal(500);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            otherCharacter = other.GetComponent<IHeal>();
        }

        private void OnTriggerExit(Collider other)
        {
            otherCharacter = null;
        }
    }
}
