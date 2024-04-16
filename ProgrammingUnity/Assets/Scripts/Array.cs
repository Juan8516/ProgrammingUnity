using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Array : MonoBehaviour
    {
        public int[] enemyId;

        //Forma poco usada en unity
        public int[] enemyIds = {100, 24, 543, 900};

        private void Start()
        {
            int myId = enemyIds[3]; // 900
            myId = enemyIds[0]; //100
        }
    }
}
