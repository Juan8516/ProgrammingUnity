using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class EnableDisableAndDestroy : MonoBehaviour
    {
        private void OnEnable()
        {
            Debug.Log("Sistema disponible");
        }

        private void OnDisable()
        {
            Debug.Log("Sistema No disponible");
        }

        private void OnDestroy()
        {
            Debug.Log("Sistema destruido");
        }
    }
}
