using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.Atributos
{
    public class SerializeHide : MonoBehaviour
    {
        [SerializeField]
        private bool shoot;

        [HideInInspector]
        public bool canRun;
    }
}
