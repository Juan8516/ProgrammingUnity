using UnityEngine;

namespace ProVideoGames.OrganizationProject
{
    public class Validation : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        [SerializeField] private SpriteRenderer _spriteRenderer;

        private void OnValidate()
        {
            if (!_spriteRenderer)
            {
                _spriteRenderer = GetComponent<SpriteRenderer>();
            }

            if (!_sprite)
            {
                Debug.Log("Missing Sprite");
                return;
            }

            _spriteRenderer.sprite = _sprite;
        }
    }
}
