using UnityEngine;

namespace ProVideoGames.Interfaces
{
    public class Lever : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interactable: UseLever");
        }
    }
}
