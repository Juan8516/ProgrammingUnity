using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.POO
{
    public class Herencias : MonoBehaviour
    {
        public int health;
        public float speed;
        public bool isLive;
        public enum EnemyAttack
        {
            None = 0,
            Punch = 1,
            Energy = 2,
            Sword = 3,
        }

        public EnemyAttack enemyAttack;

        public void AttackOne()
        {
            switch (enemyAttack = 0)
            {
                case EnemyAttack.None:
                    break;
                case EnemyAttack.Punch:
                    break;
                case EnemyAttack.Energy:
                    break;
                case EnemyAttack.Sword:
                    break;
                default:
                    break;
            }
        }
    }
}
