using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class StartAwake : MonoBehaviour
    {
        //Awake: Se utiliza para la inicialización global.
        private void Awake()
        {
            Debug.Log("Desde Awake");
        }

        //Start: Se utiliza para la inicialización específica del objeto.
        private void Start()
        {
            Debug.Log("Desde Start");
        }
    }
}
