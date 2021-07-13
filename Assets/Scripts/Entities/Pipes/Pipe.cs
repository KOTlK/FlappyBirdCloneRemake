using System.Collections;
using UnityEngine;
using Containers;
using Extensions;

namespace Entities
{
    public class Pipe : MonoBehaviour
    {
        private const float _deviation = 1.5f;
        private Camera Camera => CameraContainer.Instance.GetItem();
        private void FixedUpdate()
        {
            if (transform.position.x < Camera.GetMinBounds().x - _deviation)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}