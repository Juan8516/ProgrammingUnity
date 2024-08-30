using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Course.Errores
{
    public class ErroresDeCodigo : MonoBehaviour
    {

        private void Start()
        {
            PrintAmmo();
        }

        #region THE REQUESTED OPERATION CAUSED A STACK OVERFLOW

        private void Update()
        {
            Play();
        }

        private void Play()
        {
            //Play();
        }

        #endregion

        #region XXX: NOT ALL CODE PATHS RETURN A VALUE

        bool isAlive;

        private int GetHealth()
        {
            if (isAlive)
            {
                return 100;
            }

            return -1;
        }

        #endregion

        #region INVALID TOKEN XXX IN CLASS, RECORD, STRUCT, OR INTERFACE MEMBER DECLARATION

        private int CalculateDamage()
        {
            int actualDamage = Random.Range(1, 10);
            return actualDamage;
        }


        #endregion

        #region AN OBJECT REFERENCE IS REQUIRED FOR THE NON-STATIC FIELD, METHOD, OR PROPERTY XXX

        //La referencia debe ser de tipo static.
        public static int currentAmmo = 50;

        static void PrintAmmo()
        {
            Debug.Log($"Current Ammo: {currentAmmo}");
        }

        #endregion

        #region XXX IS A TYPE, WHICH IS NOT VALID IN THE GIVEN CONTEXT

        [HideInInspector] public Color myColor;

        private void IsAFieldButATypeWasExcepted()
        {
            //myColor = Color; (la clase se debe asignar los valores correspondientes)
            myColor = new Color(1, 1, 1, 1);
            myColor = Color.white;
            myColor = new Color();
        }

        #endregion

        #region THE NAME XXX DOES NOT EXIST IN THE CURRENT CONTEXT

        //Se debe crear refeencia para usar en funcion.
        GameObject superWeapon;

        private void NameDoesNotExist()
        {
            superWeapon = new GameObject();
        }

        #endregion

        #region CANNOT IMPLICITY CONVERT TYPE XXX TO XXX

        int valueInt;
        float valueFloat;

        private void CannotImplicityConvert()
        {
            valueFloat = 3.5f;
            //Se debe castear valor.
            valueInt = (int)valueFloat;
        }

        #endregion

        #region OPERATOR XXX CANNOT BE APPLIED TO OPERANDS OF TYPE XXX AND XXX

        int myInt;
        string myString;

        private void OperatorCannotBeApplied()
        {
            //No se pueden igualar un string con un entero.
            if (5 == myInt)
            {
                // Do Something
            }
        }

        #endregion

        #region NON-INVOCABLE MEMBER XXX CANNOT BE USED LIKE A METHOD

        [HideInInspector] public GameObject myWeapon;

        //Las clases no se pueden asignar como las funciones.

        //private void EquipWeapon0()
        //{
        //    myWeapon = GameObject();
        //}
        private void EquipWeapon()
        {
            myWeapon = GetNewWeapon();
        }

        private GameObject GetNewWeapon()
        {
            return new GameObject();
        }

        #endregion

        #region XXX MUST HAVE A RETURN TYPE

        public void Run()
        {
            //Las funciones deben devolver un valor, ejemplo void, int, string etc.
        }

        #endregion

        #region THERE IS NO ARGUMENT GIVEN THAT CORRESPONDS TO THE REQUIRED FORMAL PARAMETER XXX OF XXX

        [HideInInspector] public GameObject myBullet;

        private void NoArgumentGivenThatCorresponds()
        {
            //Se pasa el segundo argumento entero correspondiente a amount
            Reload(myBullet, 2);
        }

        private void Reload(GameObject bulletType, int amount)
        {

        }

        #endregion

        #region NO OVERLOAD FOR METHOD XXX TAKES X ARGUMENTS

        private void NoOverloadForMethod()
        {
            Shoot(myBullet, 2);
        }

        private void Shoot(GameObject bulletType)
        {

        }


        private void Shoot(GameObject bulletType, int ammo)
        {
            Debug.Log("Se crea metodo para controlar argumento entero");
        }

        #endregion

        #region XXX EXPECTED

        private void Reload()
        {
            int myValue;
            myValue = 5;
            Debug.Log(myValue);
            Debug.Log("Para mostrar valor se agrega ; al final de variable myValue");
        }

        #endregion

        #region THE TYPE OR NAMESPACE NAME XXX COULD NOT BE FOUND
        
        //[Header("Se agrega directiva 'using UnityEngine.UI'")]
        //[Space]
        //public Button myButton;

        #endregion

        #region INDEX WAS OUTSIDE THE BOUNDS OF THE ARRAY

        //[Header("Array no tiene longitud necesaria")]
        //[Space]
        //public int[] myArray;

        //private void IndexOutOfRange()
        //{
        //    int myInt = myArray[5];
        //}

        #endregion

        #region OBJECT REFERENCE NOT SET TO AN INSTANCE OF AN OBJECT

        //private void NullReference()
        //{

        //    GameObject myPlayer = GameObject.Find("Player");

        //    myPlayer.transform.position = Vector3.zero;
        //}

        #endregion

        #region THE VARIABLE XXX OF XXX HAS NOT BEEN ASSIGNED

        //[Header("No gameobject assigned")]
        //[Space]
        //public GameObject myGameObject;
        //private void UnassignedReference()
        //{
        //    myGameObject.transform.position = Vector3.zero;
        //}

        #endregion

    }
}
