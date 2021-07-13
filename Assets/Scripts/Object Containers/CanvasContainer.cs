using System.Collections;
using UnityEngine;

namespace Containers
{
    public class CanvasContainer : Container<Canvas>
    {
        public static CanvasContainer Instance;
        private void Awake()
        {
            Init();
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Debug.Log("NOOOOOOO!OO!O!O!O");
            }
        }
    }
}