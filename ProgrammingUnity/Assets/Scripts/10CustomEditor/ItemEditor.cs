using UnityEngine;
using UnityEditor;

namespace ProVideoGames.CustomEditor
{
    [UnityEditor.CustomEditor(typeof(Item))]
    public class ItemEditor : Editor
    {
        private Item currentTarget;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();  

            currentTarget = (Item)target;

            if (GUILayout.Button("Execute"))
            {
                currentTarget.Consume();
            }
        }
    }
}
