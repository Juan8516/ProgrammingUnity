using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ProVideoGames.CustomEditor
{
    public class Item : MonoBehaviour
    {
        public ItemOS data;
        [Space]
        public Image itemimg;
        public TextMeshProUGUI itemTitleTxt;
        public TextMeshProUGUI itemPriceTxt;

        public void Start()
        {
            Consume();
        }

        public void Consume()
        {
            itemimg.sprite = data.sprite;
            itemTitleTxt.text = data.title;
            itemPriceTxt.text = data.GetPrice();
        }
    }
}
