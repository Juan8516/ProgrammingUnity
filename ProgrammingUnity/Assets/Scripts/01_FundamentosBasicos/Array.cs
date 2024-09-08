using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Array : MonoBehaviour
    {
        public int[] enemyId;
        public string[] namesHeroes;

        //Forma poco usada en unity
        public int[] enemyIds = {100, 24, 543, 900};

        public string[] namesHeroesId = { "Superman", "Batman", "Flash" };

        private void Start()
        {
            int myId = enemyIds[3]; //900
                myId = enemyIds[0]; //100

            string myHero = namesHeroesId[0];
                   myHero = namesHeroesId[2];
        }

    }
}
