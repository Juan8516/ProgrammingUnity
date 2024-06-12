using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProVideoGames.Atributos
{
    public class RequiredComponent : MonoBehaviour
    {
        private BoxCollider _boxCollider;
        public Rigidbody _rigidbody;

        private void Awake()
        {
            _boxCollider = GetComponent<BoxCollider>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            _boxCollider.enabled = true;
            _rigidbody.isKinematic = false;
        }
    }
}
