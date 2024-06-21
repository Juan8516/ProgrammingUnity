using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace ProVideoGames.Interfaces
{
    public class Generics : MonoBehaviour
    {
        public List<int> numbers;
        public List<string> words;

        void Start()
        {
            numbers = ReverseList(numbers);
            words = ReverseList(words);
        }

        private List<T> ReverseList<T>(List<T> listToReverse)
        {
            List<T> reverseList = new List<T>();

            for (int i = listToReverse.Count -1; i >= 0; i--)
            {
                reverseList.Add(listToReverse[i]);
            }

            return reverseList;
        }
    }
}
