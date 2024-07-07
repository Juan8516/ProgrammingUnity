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

            if (IsTargetReady())
            {

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
            else
            {
                EditorGUILayout.HelpBox($"Error: {GetErrorMessage()}", MessageType.Error);
            }
        }

        private bool IsTargetReady()
        {
            return 
                currentTarget.data &&
                currentTarget.itemimg &&
                currentTarget.itemTitleTxt &&
                currentTarget.itemPriceTxt;
        }

        private string GetErrorMessage()
        {
            if (!currentTarget.data) return "Data Empty";
            if (!currentTarget.itemimg) return "Image Reference Empty";
            if (!currentTarget.itemTitleTxt) return "Title Reference Empty";
            if (!currentTarget.itemPriceTxt) return "Price Reference Empty";
            
            return "Unknown";
        }

    }
}
