using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class VisibleAndInvisible : MonoBehaviour
    {
        private void OnBecameVisible()
        {
            Debug.Log("Hola estoy visible");
        }

        private void OnBecameInvisible()
        {
            Debug.Log("Hola no estoy visible");
        }
    }
}
