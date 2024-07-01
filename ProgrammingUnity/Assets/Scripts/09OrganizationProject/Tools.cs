using UnityEngine;

namespace ProVideoGames.Tools
{
    public static class Tools
    {
        public static RectTransform GetReactTransform(this Transform t)
        {
            return t as RectTransform;
        }
    }
}
