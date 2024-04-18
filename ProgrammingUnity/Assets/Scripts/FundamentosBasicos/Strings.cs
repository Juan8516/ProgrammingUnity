using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Strings : MonoBehaviour
    {
        string myString;

        void Start ()
        {
            myString = "Juan";
            myString = "Juan Manuel" + " " + "Salazar";
            int age = 27;

            //Dos formas
            //1ra
            myString = "Juan Manuel: " + age + ToString();

            //2da - hace que el código sea más claro y menos propenso a errores a diferencia de ToString.
            myString = string.Format("{0} Cumpleaños: {1}", "Juan", age);
            myString = $"Juan Cumpleaños: {age}";

            //Ejemplo - practico
            myString = "39_Juan_Rifle";
            string[] characterInfo = myString.Split('_');
            //Salida
            // characterInfo[0] = "39";
            // characterInfo[1] = "Juan";
            // characterInfo[2] = "Rifle";
        }
    }
}
