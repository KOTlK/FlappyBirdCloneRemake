using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Containers;
using Entities;
using Extensions;

namespace GameLogic
{
    public class PipeFactory
    {
        private const float _spawnYOffset = 3f;
        private float _offset;
        private Vector2 _startPosition;

        private PipeContainer Container => PipeContainer.Instance;
        private Camera Camera => CameraContainer.Instance.GetItem();

        public PipeFactory( float offset, Vector2 startPosition)
        {
            _offset = offset;
            _startPosition = startPosition;
        }


        public void SpawnPipes()
        {
            if (Container.GetItemsList().Length > 0)
            {
                foreach (Pipe i in Container.GetItemsList())
                {
                    if (i.gameObject.activeSelf == false)
                    {
                        Vector2 position = _startPosition;
                        position.x += _offset;
                        position.y = Random.Range(Camera.GetMinBounds().y + _spawnYOffset, Camera.GetMaxBounds().y - _spawnYOffset);
                        _startPosition = position;
                        i.transform.position = position;
                        i.gameObject.SetActive(true);
                    }
                }
            }
            
        }




    }
}

