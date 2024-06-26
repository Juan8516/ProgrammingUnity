using UnityEngine;
using UnityEngine.Events;
using System;

namespace ProVideoGames.ActionsEventsDelegates
{
    public class Action : MonoBehaviour
    {
        public System.Action myActionVar;
        public UnityAction myUnityActionVar;

        public System.Action<int> myActionOneParamVar;
        public UnityAction<int> myUnityActionOneParamVar;

        public System.Action<int, bool, string> myActionThreeParamVar;
        public UnityAction<int, bool, string> unityActionThreeParamsVar;


        // Start is called before the first frame update
        private void Start()
        {
            //Action
            myActionVar = PrintMessage;
            myActionVar += PrintMessage;

            myActionVar();
            myActionVar.Invoke();

            myActionOneParamVar = SendInteger;
            myActionOneParamVar(5);

            myActionThreeParamVar.Invoke(5, true, "Simon");

            //UnityAction
            myUnityActionVar = PrintMessage;
            myUnityActionVar += PrintMessage;

            myUnityActionVar();
            myUnityActionVar.Invoke();

            myUnityActionOneParamVar = SendInteger;
            myUnityActionOneParamVar(8);

            myActionThreeParamVar.Invoke(6, false, "Juan");
            
        }

        private void PrintMessage()
        {
            Debug.Log("Hello World !!!");
        }

        private void SendInteger(int value)
        {
            Debug.Log(value);
        }   
   
    }
}
