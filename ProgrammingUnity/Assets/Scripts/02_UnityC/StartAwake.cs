using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class StartAwake : MonoBehaviour
    {
        /*
         
            Awake: Se llama una vez por objeto antes de Start.
            Awake: Sirve para inicializar variables y tareas previas al juego.
            Awake: Inicializaci�n global. 
        
            Start: Inicializaci�n del objeto.
            Start: Se llama una vez por objeto despu�s de Awake en todos.
            Start: Se usa para configurar el objeto y comenzar la ejecuci�n del c�digo.

         */

        //Awake: Se utiliza para la inicializaci�n global.
        private void Awake()
        {
            Debug.Log("Desde Awake");
        }

        //Start: Se utiliza para la inicializaci�n espec�fica del objeto.
        private void Start()
        {
            Debug.Log("Desde Start");
        }
    }
}
