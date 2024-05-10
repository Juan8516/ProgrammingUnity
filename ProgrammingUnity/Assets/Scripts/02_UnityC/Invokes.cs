using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Invokes : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Invoke("CallInvoke", 3f);
            InvokeRepeating("CallRepeatInvoke", 3f, 2f);


            if(IsInvoking("CallInvoke"))
            {
                Debug.Log("Se esta ejecutando invoke");

            }
            else
            {
                Debug.Log("No se esta ejecuntando invoke");
            }
            
            if(IsInvoking("CallRepeatInvoke"))
            {
                Debug.Log("Se esta ejecutando repeatInvoke");
            }
            else
            {
                Debug.Log("No se esta ejecuntando repeatInvoke");
            }
        }

        void CallInvoke()
        {
            Debug.Log("Desde Invoke");
        }

        void CallRepeatInvoke() 
        {
            Debug.Log("Desde RepeatInvoke");
        }
    }
}
