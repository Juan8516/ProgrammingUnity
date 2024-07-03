using UnityEngine;

namespace ProVideoGames.OrganizationProject
{
    [CreateAssetMenu(fileName ="FileConfig", menuName ="MenuConfig", order = 1)]
    public class ConfigOS : ScriptableObject
    {
        [Header("General")]
        public int maxPlayers = 4;
        public float maxSpeedMovement = 1.2f;

        [Header("Animation")]
        public float fadeinTime = 1.5f;
        public float fadeOutTime = 3;
    }
}
