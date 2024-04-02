using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CraftyCrook.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        private float _horizontal;
        private float _vertical;
        private Rigidbody2D _playerRb;
        [SerializeField] private float _moveSpeed = 10f;

        // Start is called before the first frame update
        void Start()
        {
            _playerRb = GetComponent<Rigidbody2D>();
        }

        public void LeftAndRight(float hInput)
        {
            _horizontal = hInput;
        }

        public void UpAndDown(float vInput)
        {
            _vertical = vInput;
        }

        private void FixedUpdate()
        {
            float speedX = _horizontal * _moveSpeed;
            float speedY = _vertical * _moveSpeed;
            _playerRb.velocity = new Vector2(speedX, speedY);
        }
    }
}
