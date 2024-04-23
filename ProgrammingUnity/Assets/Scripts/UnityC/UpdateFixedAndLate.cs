using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class UpdateFixedAndLate : MonoBehaviour
    {
        private void Update()
        {
            Debug.Log("En Update");
        }
        private void LateUpdate()
        {
            Debug.Log("En LateUpdate");
        }
        private void FixedUpdate()
        {
            Debug.Log("En FixedUpdate");
        }
    }
}
