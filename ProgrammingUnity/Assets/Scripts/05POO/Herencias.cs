using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.POO
{
    public abstract class Herencias : MonoBehaviour
    {
        [Header("Enemy")]

        [SerializeField] protected string _title;
        [SerializeField] protected int health;
        [SerializeField] protected int demage;
        public float speed;
        public bool isLive;
        public enum EnemyAttack
        {
            None = 0,
            Punch = 1,
            Energy = 2,
            Sword = 3,
        }

        public enum EnemyDefense
        {
            None = 0,
            DefenseMagican = 1,
            DefenseShield = 2,
            DefenseCap = 3,
        }

        public EnemyAttack enemyAttack;
        public EnemyDefense defense;

        public string Title 
        {
            get 
            { 
                return _title; 
            } 
            
            set 
            {
                _title = value; 
            } 
        }

        private void Start()
        {
            Attack();
            Defense();
        }

        public virtual void Attack()
        {
            Debug.Log($"Enemy: '{_title}' Attack. Demage: '{demage}'");
            Debug.Log(enemyAttack = EnemyAttack.Energy);
        }

        public abstract void Defense();
    }
}
