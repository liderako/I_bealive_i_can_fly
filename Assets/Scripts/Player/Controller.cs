using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Controller : MonoBehaviour
    {
        [SerializeField] private GameObject _airplane;
        [SerializeField] private float _speed;
        private bool _trend;
        
        /*
         * tmp var
         */
        private Vector3 _oldPosition;
        
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnClick();
            }
            Move();
        }

        private void Move()
        {
            if (_trend)
            {
                _airplane.transform.RotateAround(transform.position, Vector3.up, _speed * Time.deltaTime);
            }
            else
            {
                _airplane.transform.RotateAround(transform.position, Vector3.down, _speed * Time.deltaTime);
            }
        }

        private void OnClick()
        {
            if (_trend)
            {
                _trend = false;
            }
            else
            {
                _trend = true;
            }
            ChangePosition();
        }

        private void ChangePosition()
        {
            _oldPosition = _airplane.transform.position;
            transform.position = new Vector3(
                _airplane.transform.position.x * 2 - transform.position.x,
                transform.position.y,
                _airplane.transform.position.z * 2 - transform.position.z);
            _airplane.transform.position = _oldPosition;
        }
    }
}
