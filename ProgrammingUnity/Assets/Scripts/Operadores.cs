using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Operadores : MonoBehaviour
    {
        int myInt;
        bool myBool;

        private void Start()
        {
            //Operadores aritmeticos
            myInt = 2 + 2;
            myInt = 4 - 2;
            myInt = 6 * 9;
            myInt = 8 / 2;

            //Operadores asignacion
            myInt += 2;
            myInt -= 2;
            myInt *= 2;
            myInt /= 2;

            //Operadores relacionales
            myBool = 2 > 1;
            myBool = 2 < 1;
            myBool = 2 == 1;
            myBool = 2 >= 1;
            myBool = 2 <= 1;
            myBool = 2 != 1;

            //Operadores Logicos
            myBool = 2 == 2 || 4 == 4; //Solo una condicion se debe cumplir
            myBool = 2 == 2 && 4 == 4; //Las dos condiciones se deben cumplir
            myBool = !(2 == 2); //Vuelve a falso la operacion del parentesis, asi sea verdadera.

        }
    }
}
