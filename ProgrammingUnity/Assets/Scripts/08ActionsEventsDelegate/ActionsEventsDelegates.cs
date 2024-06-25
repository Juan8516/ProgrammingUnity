using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.MemoryProfiler;
using UnityEngine;

namespace ProVideoGames.ActionsEventsDelegates
{
    public class ActionsEventsDelegates : MonoBehaviour
    {

        //----------------Delegate----------------

        //Void
        public delegate void myDelegate();
        public myDelegate myDelegateVar;

        //Return
        public delegate int MyDelegateInt();
        public MyDelegateInt myDelegateIntVar;

        //Params
        public delegate void MyDelegateParams(string myString);
        public MyDelegateParams myDelegateParamsVar;

        //Multicast
        public delegate void MyDelegateMulticast();
        public MyDelegateMulticast myDelegateMulticastVar;

        //Callback
        public delegate void MyDelegateCallback(bool myBool);
        public MyDelegateCallback myDelegateCallbackVar;

        // Start is called before the first frame update
        private void Start()
        {
            //Void - Call it
            myDelegateVar = SendMessage;
            //myDelegateVar();
            //myDelegateVar.Invoke();

            //Return - Call it
            myDelegateIntVar = GetWeaponId;
            int myWeapon;
            myWeapon = myDelegateIntVar();
            myWeapon = myDelegateIntVar.Invoke();

            //Params - Call it
            myDelegateParamsVar = SendMessageWithParams;
            myDelegateParamsVar("Juan");
            myDelegateParamsVar.Invoke("Juan");

            //Multicast - Call it
            myDelegateMulticastVar += SendMessage;
            myDelegateMulticastVar += ChangeWeapon;
            myDelegateMulticastVar += Heal;
            myDelegateMulticastVar();
            myDelegateMulticastVar.Invoke();
            
            //Callback - Call it
            myDelegateCallbackVar = RequestCompleted;
            RequestConnection(myDelegateCallbackVar);

        }

        //Void
        private void SendMessage( )
        {
            Debug.Log("Hello World!");
        }

        //Params
        private void SendMessageWithParams(string message)
        {
            Debug.Log($"Hello {message}!!");
        }

        //Return
        private int GetWeaponId()
        {
            return 15;
        }

        //Multicast
        private void ChangeWeapon()
        {
            Debug.Log("Changed Weapon");
        }

        private void Heal()
        {
            Debug.Log("Character Heal");
        }

        //Callback
        bool connectionReady = true;

        private void RequestConnection(MyDelegateCallback callback)
        {
            if(connectionReady)
            {
                callback(true);
                callback.Invoke(true);
            }
            else
            {
                callback(false);
                callback.Invoke(false);
            }
        }

        private void RequestCompleted(bool sucess)
        {
            Debug.Log($"Connection Ready: {sucess}");
        }
    }
}
