using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace ProVideoGames.Collections
{
    public class ClassDictionary : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Dictionary")]
        public Dictionary<string, GameObject> characterDictionary;
        
        
        // Start is called before the first frame update
        void Start()
        {
            //init
            characterDictionary = new Dictionary<string, GameObject>();

            //Add
            for (int i = 0; i < myContent.Length; i++)
            {
                characterDictionary.Add(myContent[i].name, myContent[i]); //Llama al GameObject que tiene el nombre correspondiente en el diccionario
            }

            //Remove
            characterDictionary.Remove("Orc");//Remueve orco

            //Contains
            bool contains = characterDictionary.ContainsKey("Orc");

            //Read
            GameObject myValue = characterDictionary["Orc"];

            //Amount
            int amount = characterDictionary.Count;

            //Clear
            characterDictionary.Clear();
      
        }
    }
}
