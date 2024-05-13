using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.Atributos
{
    public class Range_Min : MonoBehaviour
    {
        [Range(1, 100)]
        public int ShooterSpeed;

        [Range(1.0f, 2.5f)]
        public float Rate;

        [Min(2.5f)]
        public float BulletSpeed;

        [Min(1)]
        public int BulletPerShoot;
    }
}
