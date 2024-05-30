using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace ProVideoGames.ControlStruct
{
    public class ForForeachWhile : MonoBehaviour
    {
        public int[] waponAmmoArray;

        private void CheckWeaponAmmo()
        {
            for(int i = 0; i  < waponAmmoArray.Length; i++)
            {
                Debug.Log($"Index {i} - Ammo: {waponAmmoArray[i]}");
            }

            foreach(int ammo in waponAmmoArray)
            {
                Debug.Log($"Index ? - Ammo: {ammo}");
            }
        }

        private IEnumerator Fade()
        {
            float alpha = 1;

            while(true)
            {
                alpha -= Time.deltaTime;
                yield return null;
            }

            //Do something

        }
    }
}
