using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class LightController : MonoBehaviour
    {
        [SerializeField]private float _speed;
        [SerializeField]private Transform _center;
        [SerializeField]private Vector3 _dir;
            
        private void Start()
        {
            int r = Random.Range(-1, 1);
            Debug.Log(r);
            if (r == 0)
            {
                _dir = Vector3.up;
            }
            else
            {
                _dir = Vector3.down;
            }
        }
        
        void Update()
        {
            transform.RotateAround(_center.position, _dir, _speed * Time.deltaTime);
        }
    }
}
