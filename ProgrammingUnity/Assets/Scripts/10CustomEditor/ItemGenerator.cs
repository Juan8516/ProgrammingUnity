using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace ProVideoGames.CustomEditor
{
    public class ItemGenerator : EditorWindow
    {
        //Item Data
        public new string title;
        public float price;
        public Sprite sprite;
        private ItemOS _data;

        private GUIStyle _styleButtons;
        private string _pathAndName = "Assets/Scripts/10CustomEditor/Item Data/New Item.asset";


        [MenuItem("Tools/Item Generator")]
        static void Init()
        {
            ItemGenerator window = (ItemGenerator)GetWindow(typeof(ItemGenerator));
            Texture2D iconTitle = EditorGUIUtility.Load("d_Prefab Icon") as Texture2D;
            GUIContent titleContent = new GUIContent("Item Generator", iconTitle);
            window.titleContent = titleContent;
            window.minSize = new Vector2(350, 250);
            window.Show();
        }

        private void OnGUI()
        {
            _styleButtons = new GUIStyle(GUI.skin.button) { alignment = TextAnchor.MiddleCenter, fontSize = 15, fixedHeight = 40};

            GUILayout.Label("Data", EditorStyles.boldLabel);

            EditorGUILayout.Space();

            title = EditorGUILayout.TextField("Title", title);

            GUILayout.Label("Price");
            price = EditorGUILayout.Slider(price, 0, 999);

            sprite = (Sprite)EditorGUILayout.ObjectField("Sprite", sprite, typeof(Sprite), true);

            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            DrawHorizontalLine();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("Create", _styleButtons))
            {
                CreateItem();

                string _itemPathAndName = AssetDatabase.GenerateUniqueAssetPath(_pathAndName);

                AssetDatabase.CreateAsset(_data, _itemPathAndName);
                AssetDatabase.RenameAsset(_itemPathAndName, title);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();

                EditorUtility.FocusProjectWindow();
                Selection.activeObject = _data;
            }            
            
            if (GUILayout.Button("Clear", _styleButtons))
            {
                ClearItem();
            }

            EditorGUILayout.EndHorizontal();
            
            //DrawSize();
        }

        private void CreateItem()
        {
            _data = CreateInstance<ItemOS>();

            _data.title = title;
            _data.price = price;
            _data.sprite = sprite;
        }

        private void ClearItem()
        {
            title = null;
            price = 0;
            sprite = null;
        }

        private void DrawHorizontalLine()
        {
            Rect rect = EditorGUILayout.GetControlRect(false, 1);
            rect.height = 1;
            EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
        }

        private void DrawSize()
        {
            EditorGUILayout.LabelField("X: " + base.position.width.ToString());
            EditorGUILayout.LabelField("Y: " + base.position.height.ToString());
        }
    }
}
