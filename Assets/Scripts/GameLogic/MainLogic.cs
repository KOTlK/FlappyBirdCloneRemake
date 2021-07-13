using System.Collections;
using UnityEngine;
using Containers;

namespace GameLogic
{
    public class MainLogic : MonoBehaviour
    {
        [SerializeField] private float _pipesOffset;
        private Vector2 _startPosition = new Vector2(5, 0);
        private PipeFactory _factory;

        private void Start()
        {
            _factory = new PipeFactory(_pipesOffset, _startPosition);
        }

        private void FixedUpdate()
        {
            _factory.SpawnPipes();
        }
    }
}