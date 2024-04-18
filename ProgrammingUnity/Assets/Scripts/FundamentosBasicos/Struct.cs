using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
        //Publico usable en otras clases
        //[System.Serializable]
        //public struct PlayerData
        //{
        //    public string name;
        //    public int health;
        //    public bool isDead;
        //}
    public class Struct : MonoBehaviour
    {
        //Conjunto de variables
        public string playerName;
        public int playerHealth;
        public bool playerIsDead;

        //Privado
        [System.Serializable]
        public struct PlayerData
        {
            public string name;
            public int health;
            public bool isDead;
        }

        public PlayerData playerData;

        private void Start()
        {
            playerData.name = "Juan Manuel Salazar";
            playerData.health = 600;
            playerIsDead = false;

        }

    }
}
