using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

namespace ProVideoGames.Atributos
{
    public class ContextMenuAndItem : MonoBehaviour
    {
        [ContextMenu("Execute")]
        private void printExecute()
        {
            Debug.Log("EXECUTE");
        }

        [ContextMenuItem("Get a Random Scale", "ExecuteRandomScale")]
        public float randomScale;

        private void ExecuteRandomScale()
        {
            randomScale = Random.Range(0, 10f);
        }
    }
}
