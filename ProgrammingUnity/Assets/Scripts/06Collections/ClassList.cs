using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.Collections
{
    public class ClassList : MonoBehaviour
    {
        [Header("Content")]
        public int[] myContent;

        [Header("List")]
        public List<int> weaponsList;

        private void Start()
        {
            //init
            weaponsList = new List<int>();

            //Add
            weaponsList.AddRange(myContent);

            //Add with for
            for (int i = 0; i < myContent.Length; i++)
            {
                weaponsList.Add(myContent[i]);
            }

            //Remove
            weaponsList.Remove(myContent[2]);

            //Read
            int tempValue = weaponsList[2];

            //Amount
            int amount = weaponsList.Count;

            //Clear
            weaponsList.Clear();
        }
    }
}
