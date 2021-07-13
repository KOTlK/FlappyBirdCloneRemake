using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Containers;

namespace Player
{
    public class Movement
    {
        private float _speed;
        private float _gravityModifier;
        private float _jumpSpeed;
        private Vector2 _targetVelocity;
        private Vector2 _velocity;
        private Rigidbody2D _body;

        public Movement(Rigidbody2D rigidBody, float speed, float gravityModifier, float jumpSpeed)
        {
            _body = rigidBody;
            _speed = speed;
            _gravityModifier = gravityModifier;
            _jumpSpeed = jumpSpeed;
        }
        public void UpdateInput()
        {
            _targetVelocity = new Vector2(1, 0);

            //POXUI
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            } else if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Jump();
            } else if (Input.touchCount > 0)
            {
                Jump();
            }
        }

        public void UpdatePosition()
        {
            _velocity += _gravityModifier * Physics2D.gravity * Time.deltaTime;
            _velocity.x = _targetVelocity.x * _speed;
            _body.velocity = _velocity;
        }

        private void Jump()
        {
            _velocity.y = _jumpSpeed;
        }
    }
}

