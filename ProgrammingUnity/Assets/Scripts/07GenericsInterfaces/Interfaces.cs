using JetBrains.Annotations;
using System.Linq;
using UnityEngine;

namespace ProVideoGames.Interfaces { 
        public interface IInteractable
        {
            void Interact();
        }

    public class Interfaces : MonoBehaviour
    {

        public GameObject[] myInteractables;

        private void Start()
        {
            for (int i = 0; i < myInteractables.Length; i++)
            {
                IInteractable myInteractable = myInteractables[i].GetComponent<IInteractable>();
                myInteractable?.Interact();
            }
        }
    }
}
