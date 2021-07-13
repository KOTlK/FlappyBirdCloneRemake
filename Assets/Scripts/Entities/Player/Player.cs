using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Containers;
using Move;

namespace Entities
{
    public class Player : MonoBehaviour
    {
        public delegate void PlayerDeath();
        public event PlayerDeath OnPlayerDeath;

        private const float _speed = 5f;
        private const float _jumpSpeed = 12.5f;
        private const float _gravityModifier = 4.5f;

        private Movement _mover;
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

        public void Die()
        {
            _status = PlayerStatus.Dead;
            OnPlayerDeath?.Invoke();
            Debug.Log("DEAD");
        }
    }
}

