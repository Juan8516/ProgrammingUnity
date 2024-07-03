using UnityEngine;

namespace ProVideoGames.OrganizationProject
{
    [CreateAssetMenu(fileName ="FileData", menuName ="MenuData", order = 0)]
    public class DataOS : ScriptableObject
    {
        [Header("Visual")]
        public string title;
        public Sprite sprite;

        [Header("Stats")]
        public float health = 100;
        public int demage = 15;

        public string GetPrintStatus()
        {
            return $"status: health: {health}, demage: {demage}";
        }
    }
}
