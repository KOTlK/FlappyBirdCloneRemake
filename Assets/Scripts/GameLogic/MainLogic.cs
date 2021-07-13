using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Containers;
using GameUI;

namespace GameLogic
{
    public class MainLogic : MonoBehaviour
    {
        [SerializeField] private float _pipesOffset;
        private Vector2 _startPosition = new Vector2(5, 0);
        private PipeFactory _factory;
        private DeathMenu _deathMenu;

        private void Start()
        {
            _deathMenu = new DeathMenu();
            _factory = new PipeFactory(_pipesOffset, _startPosition);
        }

        private void FixedUpdate()
        {
            _factory.SpawnPipes();
        }

        public void RestartLevel()
        {
            SceneManager.LoadScene("SampleScene");
            _deathMenu.HideDeathMenu();
            Time.timeScale = 1;
        }
    }
}