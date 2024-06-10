using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.POO
{
    public class Heredero : Herencias
    {
        private void Start()
        {
            health = 999;

            base.Attack();

            Debug.Log($"Ataque '{enemyAttack = EnemyAttack.Punch}' Demage: '{demage}'");
        }

        public override void Defense()
        {
            Debug.Log($"Enemy '{_title}' Defense: '{health}'");
        }
    }
}
