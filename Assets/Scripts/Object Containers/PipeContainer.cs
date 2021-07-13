using UnityEngine;
using Entities;

namespace Containers
{
    public class PipeContainer : Container<Pipe>
    {
        public static PipeContainer Instance;
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
