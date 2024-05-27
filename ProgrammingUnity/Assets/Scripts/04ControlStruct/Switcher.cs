using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.ControlStruct
{
    public enum EPlatform
    {
        None,
        Xbox,
        Nintendo,
        PlayStation,
        Pc
    }
    public class Switcher : MonoBehaviour
    {
        public int weaponType;
        public string enemyClass;
        public EPlatform currentPlatform;

        // Start is called before the first frame update
        void Start()
        {
            //int
            switch (weaponType)
            {
                case 1:
                    //Do something
                    case 2: 
                    case 3:
                        //Do somenthing
                    break;

                case 4:
                    break;

                default:
                    break;
            }

            //string
            switch (enemyClass)
            {
                case "Hola":
                    break;

                case "Mundo":
                    break;

                default:
                    break;
            }

            //enum
            switch (currentPlatform)
            {
                case EPlatform.None:
                    break;
                case EPlatform.Xbox:
                    break;
                case EPlatform.Nintendo:
                    break;
                case EPlatform.PlayStation:
                    break;
                case EPlatform.Pc:
                    break;
                default:
                    break;
            }
        }

    }
}
