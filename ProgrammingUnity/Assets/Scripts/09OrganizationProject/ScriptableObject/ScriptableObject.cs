using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.OrganizationProject
{
    public class ScriptableObject : MonoBehaviour
    {
        private DataOS data;
        // Start is called before the first frame update
        void Start()
        {
            data.title = "Megatron";
        }
    }
}
