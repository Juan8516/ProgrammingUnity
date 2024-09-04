using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Enums : MonoBehaviour
    {
        // 0 = fire
        // 1 = Ice
        // 2 = Sword
        // 3 = Punch
        //public int attackTypeInt;

        //enum list
        public enum AttackType
        {
            None,
            Fire,
            Ice,
            Sword,
            Punch
        }

        //Enum list
        public enum DefenceType
        {
            None,
            Shield,
            PowerBarrier,
            Energy
        }

        
        public AttackType attackTypeEnum;
        public DefenceType defenceType;

        private void Start()
        {
            attackTypeEnum = AttackType.Sword;
            defenceType = DefenceType.Energy;
        }
    }
}
