using UnityEngine;

namespace ProVideoGames.CustomEditor
{
    [CreateAssetMenu(fileName ="New Item", menuName ="ScriptableObject/Item", order =0)]   
    public class ItemOS : ScriptableObject
    {
        public Sprite sprite;
        public string title;
        public float price;

        public string GetPrice()
        {
            return string.Format("Price: {0}", price);
        }
    }
}
