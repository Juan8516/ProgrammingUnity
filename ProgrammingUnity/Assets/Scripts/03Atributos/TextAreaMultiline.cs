using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.Atributos
{
    public class TextAreaMultiline : MonoBehaviour
    {
        [TextArea(1, 10)]
        public string Description;

        [Multiline(6)]
        public string Note;
    }
}
