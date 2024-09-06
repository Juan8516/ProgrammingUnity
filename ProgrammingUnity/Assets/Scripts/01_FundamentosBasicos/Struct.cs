using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    //Publico usable en otras clases
    [System.Serializable]
    public struct PlayerData
    {
        public string name;
        public int health;
        public bool isDead;
    }
    public class Struct : MonoBehaviour
    {
        //Conjunto variables player
        public string playerName;
        public int playerHealth;
        public bool playerIsDead;

        //Privado
        [System.Serializable]
        public struct PlayerData
        {
            public string namePlayer;
            public int healthPlayer;
            public bool isDeadPLayer;
        }

        public PlayerData playerData;

        //Conjunto variables enemigo.
        public string nameEnemy;
        public int healthEnemy;
        public bool isDeadEnemy;

        public struct EnemyData 
        {
            public string nameEnemy;
            public int healthEnemy;
            public bool isDeadEnemy;
        }

        public EnemyData enemyData;
        private void Start()
        {
            playerData.namePlayer = "Juan Manuel Salazar";
            playerData.healthPlayer = 600;
            playerData.isDeadPLayer = false;

            enemyData.nameEnemy = "Thanos";
            enemyData.healthEnemy = 1000;
            enemyData.isDeadEnemy = false;
        }
    }
}
