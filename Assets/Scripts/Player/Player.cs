using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Containers;

namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;
        [SerializeField] private float _jumpSpeed;
        private Movement _mover;
        [SerializeField] private float _gravityModifier = 2.5f;
        private PlayerStatus _status;
        private Rigidbody2D PlayerBody => PlayerContainer.Instance.GetItem();

        private void Start()
        {
            _mover = new Movement(PlayerBody, _speed, _gravityModifier, _jumpSpeed);
            _status = PlayerStatus.Alive;
        }


        private void Update()
        {
            _mover.UpdateInput();
        }

        private void FixedUpdate()
        {
            _mover.UpdatePosition();
        }

        public PlayerStatus GetCurrentStatus()
        {
            return _status;
        }
    }
}

