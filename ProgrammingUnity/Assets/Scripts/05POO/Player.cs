using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.POO
{
    public class  Player : MonoBehaviour
    {
        public Herencias enemy;

        private void Start()
        {
            float templeHealth = enemy.demage;
        }

    }
}
