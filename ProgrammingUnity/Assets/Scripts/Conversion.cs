using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ProVideoGames.FundamentosProgramacion.Enums;

namespace ProVideoGames.FundamentosProgramacion
{
    public class Conversion : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //Conversion tipo cast
            int myCastInt = (int)2.55f;

            Collider myCollider = GetComponent<Collider>();
            BoxCollider myBoxCollider;

            myBoxCollider = (BoxCollider)myCollider;
            myBoxCollider = myCollider as BoxCollider;


            //Conversion tipo parse
            string myStringInt = "128";
            int myIntParsed;

            myIntParsed = int.Parse(myStringInt); //128
            bool resultParse = int.TryParse(myStringInt, out myIntParsed);


            //Conversion tipo enum
            string myStringEnum = "Fire";

            AttackType myEnum;
            myEnum = (AttackType)System.Enum.Parse(typeof(AttackType), myStringEnum);
        }
    }
}
