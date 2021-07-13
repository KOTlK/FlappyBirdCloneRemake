using UnityEngine;

namespace Containers
{
    public class CameraContainer : Container<Camera>
    {
        public static CameraContainer Instance;
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
