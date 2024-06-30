using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.OrganizationProject
{
    public class Documentation : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            int myValue;
            myValue = GetId("Juan");
        }

        /// <summary>
        ///     Sumary: Descripcion corta
        /// </summary>
        /// <remarks>
        ///     Remarks: Descripcion detallada
        /// </remarks>
        /// <param name="characterName"> Param: Descripcion de la variable </param>
        /// <returns>
        ///     Returns: Descripcion del tipo de valor que devuelve
        /// </returns>
        private int GetId(string characterName)
        {
            return 1;
        }

    }
}
