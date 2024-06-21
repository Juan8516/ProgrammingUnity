using UnityEngine;

namespace ProVideoGames.Interfaces
{
    public class Door : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interactable: Door");
        }
    }
}
