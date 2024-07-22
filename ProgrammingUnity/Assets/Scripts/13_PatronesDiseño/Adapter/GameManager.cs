using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseno.Adapter
{
    public class GameManager : MonoBehaviour
    {
        private SaveSystem saveSystem;

        private void Start()
        {
            saveSystem = new SaveSystem(new PlayerPrefsAdapter());
        }

    }
}
