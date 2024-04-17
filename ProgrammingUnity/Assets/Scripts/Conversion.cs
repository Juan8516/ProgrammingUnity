using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            //Conversion tipo enum
        }
    }
}
