using UnityEngine;

namespace ProVideoGames.CustomEditor
{
    public class Avatar : MonoBehaviour
    {
        [SerializeField]
        private int[] lives;

        private void Start()
        {
            GetLive();
        }

        private void GetLive()
        {
            for (int i = 0; i < lives.Length; i++)
            {
                Debug.Log("Tiene Vidas");
            }

        }
    
    }
}
