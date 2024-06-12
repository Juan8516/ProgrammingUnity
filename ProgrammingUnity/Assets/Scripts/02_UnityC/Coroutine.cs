using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Coroutine : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            #region Start
            //Initialization
            StartCoroutine(CallCoroutine());

            StartCoroutine("CallCoroutine");

            //Coroutine myCoroutine;
            //myCoroutine = StartCoroutineCallCoroutine();
            #endregion

            #region stop
            //Stop
            StopCoroutine(CallCoroutine());

            StopCoroutine("CallCoroutine");

            StopCoroutine("Nombre Coroutine");

            StopAllCoroutines();
            #endregion

            #region Parametros
            //Parametros
            StartCoroutine(CallCoroutineWithParams(7.3f, 16, "Test"));

            //Coroutine myCoroutine;
            //myCoroutine = StartCoroutine(CallCoroutineWithParams(7.3f, 16, "Test"));

            #endregion
        }

        private IEnumerator CallCoroutine()
        {
            yield return null;
        }

        private IEnumerator CallCoroutineWithParams(float myFloat, int myInt, string myString)
        {
            yield return null;
        }
    }
}
