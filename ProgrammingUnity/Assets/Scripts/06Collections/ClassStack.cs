using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.Collections
{
    public class ClassStack : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Stack")]
        public Stack<GameObject> cardsStack;

        // Start is called before the first frame update
        void Start()
        {
            //Init
            cardsStack = new Stack<GameObject>();

            //Add
            for (int i = 0; i < myContent.Length; i++)
            {
                cardsStack.Push(myContent[i]);
            }

            //Return and Remove
            GameObject myGameObjectPop = cardsStack.Pop();

            //Return First
            GameObject myGameObjectPeek = cardsStack.Peek();

            //Contains
            cardsStack.Contains(myGameObjectPeek);

            //Amount
            int amount = cardsStack.Count;

            //Clear
            cardsStack.Clear();
        }
    }
}
