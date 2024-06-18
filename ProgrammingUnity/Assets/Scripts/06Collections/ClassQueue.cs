using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.Collections
{
    public class ClassQueue : MonoBehaviour
    {
        [Header("References")]
        private GameObject[] myContent;

        [Header("Queue")]
        public Queue<GameObject> playerQueue;

        // Start is called before the first frame update
        void Start()
        {
            //Init
            playerQueue = new Queue<GameObject>();

            //Add
            for (int i = 0; i < myContent.Length; i++)
            {
                playerQueue.Enqueue(myContent[i]);
            }

            //Remove
            GameObject myGameObject = playerQueue.Dequeue();

            //Contains
            bool contains = playerQueue.Contains(myGameObject);

            //Amount
            int amount = playerQueue.Count;

            //Clear
            playerQueue.Clear();
        }
    }
}
