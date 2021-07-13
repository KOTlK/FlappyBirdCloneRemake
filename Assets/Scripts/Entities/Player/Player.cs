using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Containers;
using Move;
using GameUI;
using GameLogic;
using Extensions;

namespace Entities
{
    public class Player : MonoBehaviour
    {
        public delegate void PlayerDeath();
        public delegate void UpdateScore(int score);
        public event PlayerDeath OnPlayerDeath;
        public event UpdateScore OnScoreUpdate;

        private const float _speed = 5f;
        private const float _jumpSpeed = 12.5f;
        private const float _gravityModifier = 4.5f;

        private int _currentScore;

        private ScoreUpdater _scoreUpdater;
        private DeathMenu _deathMenu;
        private Movement _mover;
        private PlayerStatus _status;
        private Rigidbody2D PlayerBody => PlayerContainer.Instance.GetItem();

        private void Start()
        {
            _currentScore = 0;
            _mover = new Movement(PlayerBody, _speed, _gravityModifier, _jumpSpeed);
            _scoreUpdater = new ScoreUpdater();
            _deathMenu = new DeathMenu();
            _status = PlayerStatus.Alive;
            OnScoreUpdate += _scoreUpdater.UpdateScore;
        }


        private void OnDisable()
        {
            OnScoreUpdate -= _scoreUpdater.UpdateScore;
        }


        private void Update()
        {
            _mover.UpdateInput();
        }

        private void FixedUpdate()
        {
            _mover.UpdatePosition();
            if (this.transform.position.y < CameraContainer.Instance.GetItem().GetMinBounds().y - 1 || 
                this.transform.position.y > CameraContainer.Instance.GetItem().GetMaxBounds().y + 1)
            {
                Die();
            }
        }

        public PlayerStatus GetCurrentStatus()
        {
            return _status;
        }

        public void Die()
        {
            _status = PlayerStatus.Dead;
            Saves.SaveBestScore(_currentScore);
            OnPlayerDeath?.Invoke();
            _deathMenu.ShowDeathMenu(_currentScore);
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.transform.TryGetComponent<GreenZone>(out GreenZone greenZone))
            {
                _currentScore++;
                OnScoreUpdate?.Invoke(_currentScore);
            }
        }

    }
}

