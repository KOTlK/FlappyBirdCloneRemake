using System.Collections;
using UnityEngine;
using Containers;

namespace Extensions
{
    public static class CameraExtension
    {
        
        public static Vector2 Max
        {

            get
            {
                Vector2 topRight = CameraContainer.Instance.GetItem().ViewportToWorldPoint(new Vector2(1, 1));
                return topRight;
            }

        }

        public static Vector2 Min
        {
            get
            {
                Vector2 bottomLeft = CameraContainer.Instance.GetItem().ViewportToWorldPoint(new Vector2(0, 0));
                return bottomLeft;
            }
        }

        public static Vector2 GetMaxBounds(this Camera self)
        {
            return Max;
        }

        public static Vector2 GetMinBounds(this Camera self)
        {
            return Min;
        }
    }
}