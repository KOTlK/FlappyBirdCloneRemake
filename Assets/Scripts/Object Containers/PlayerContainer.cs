using UnityEngine;

namespace Containers
{
    class PlayerContainer : Container<Rigidbody2D>
    {
        public static PlayerContainer Instance;
        private void Awake()
        {
            Init();
            if (Instance == null)
            {
                Instance = this;
            } else
            {
                Debug.Log("NOOOOOOO!OO!O!O!O");
            }
        }
    }
}
