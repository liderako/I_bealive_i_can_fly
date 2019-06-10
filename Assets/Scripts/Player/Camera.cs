using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Camera : MonoBehaviour
    {
        [SerializeField] private GameObject _player;

        private Vector3 _offset;

        void Start()
        {
            _offset = transform.position - _player.transform.position;
        }

        void Update()
        {
            Move();
        }

        private void Move()
        {
            transform.position = _player.transform.position + _offset;
        }
    }
}