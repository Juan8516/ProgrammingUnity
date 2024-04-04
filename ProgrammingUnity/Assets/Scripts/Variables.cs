using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace ProVideoGames.FunfamentosProgramacion
{
    public class Variables : MonoBehaviour
    {
        s/*Partes de una variable*/

        // - Modificador de acceso
        // Public 
        // Private

        // - Tipos de datos
        // int 
        // float
        // bool
        // string

        // - Nombre
        // Nombre acorde a lo que se esta usando y el tipo de dato: age, isDead etc

        // - Valor por defecto (opcional)


        // - Ejemplos
        // Variables
        public string playerName = "Juan";
        private int age = 27;

        // Tipos de datos (valor)
        public int myInt;
        public float myFloat;
        public double myDouble;
        public bool myBool;
        public char myChar;
        public Vector2 myStructVector2;
        public Vector3 myStructVector3;
        public Quaternion myStructQuaternion;

        // Tipos de datos (referencia)
        public Transform myClassTransform;
        public GameObject myClassGameObject;
        public Variables myClass;

        private void Start()
        {
            // Tipos de datos (valor)
            myInt = 18;
            myFloat = 5.0f;
            myBool = false;
            myChar = 'S';
            myStructVector2 = new Vector2(1, 2);
            myStructVector2 = new Vector3(1, 2, 3);
            myStructQuaternion = new Quaternion(1, 2, 3, 4);

            // Tipos de datos (referencia)
            myClassTransform = this.transform;
            myClassGameObject = this.gameObject;
            myClass = this;
        }
    }
}
