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
            Awake: Inicialización global. 
        
            Start: Inicialización del objeto.
            Start: Se llama una vez por objeto después de Awake en todos.
            Start: Se usa para configurar el objeto y comenzar la ejecución del código.

         */

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
