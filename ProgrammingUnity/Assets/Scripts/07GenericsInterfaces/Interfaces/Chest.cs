using UnityEngine;

namespace ProVideoGames.Interfaces
{
    public class Chest : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interactable: Chest");
        }
    }
}
