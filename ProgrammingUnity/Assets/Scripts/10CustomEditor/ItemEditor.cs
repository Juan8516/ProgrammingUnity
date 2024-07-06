using UnityEngine;
using UnityEditor;
using UnityEditor.Networking.PlayerConnection;

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

            GUILayout.Space(10);

            if (!EditorApplication.isPlaying)
                GUILayout.Box($"Data: {currentTarget.data.title} - {currentTarget.data.price}");

            EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);
            

            string buttonText = EditorApplication.isPlaying ? "Consume (only in Editor Mode)" : "Consume";

            if (GUILayout.Button(buttonText, GUILayout.Height(30)))
            {
                currentTarget.Consume();
            }
            
            EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);
        }
    }
}
