using UnityEngine;
using UnityEngine.Events;

namespace ProVideoGames.ActionsEventsDelegates
{
    public class Events : MonoBehaviour
    {
        //----------------Events----------------

        //Events C#
        public delegate void MyDelegateEvents();
        public event MyDelegateEvents myEventVar;

        //Events Unity
        public UnityEvent myUnityEventVar;
        public UnityEvent<bool> myUnityEventOneParam;
        public UnityEvent<bool, int, string> myUnityEventThreeParam;

        // Start is called before the first frame update
        void Start()
        {
            //Events C#
            myEventVar += PrintMessage;
            myEventVar();
            myEventVar.Invoke();

            //Events C#
            myUnityEventVar.AddListener(PrintMessage); //+=
            myUnityEventVar.RemoveListener(PrintMessage); //-=

            myUnityEventOneParam.Invoke(true);
            myUnityEventThreeParam.Invoke(true, 3, "Simon");
        }

        private void PrintMessage()
        {
            Debug.Log("Hello World!!");
        }
    }
}
