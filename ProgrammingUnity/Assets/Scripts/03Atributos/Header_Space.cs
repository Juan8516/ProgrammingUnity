using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Header_Space : MonoBehaviour
    {
        [Header("Stats")]
        public string displyName;

        [Space]
        public int health;
        public int mana;

        [Space(15)]
        public bool isAlive;

        [Header("References")]
        public CapsuleCollider capsuleCollider;
    }
}
