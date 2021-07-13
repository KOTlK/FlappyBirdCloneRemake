using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Containers;

namespace GameCamera
{
    public class CameraFollow : MonoBehaviour
    {
        private float _cameraOffset;
        private Camera Camera => CameraContainer.Instance.GetItem();
        private Rigidbody2D Player => PlayerContainer.Instance.GetItem();


        private void Start()
        {
            _cameraOffset = Camera.aspect * 4;
        }
        private void FixedUpdate()
        {
            Vector3 newPosition = new Vector3(Player.transform.position.x, 0, -10);
            newPosition.x += _cameraOffset;
            Camera.transform.position = newPosition;
        }
    }
}

