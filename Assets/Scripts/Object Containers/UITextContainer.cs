using UnityEngine;
using UnityEngine.UI;

namespace Containers
{
    public class UITextContainer : Container<Text>
    {
        public static UITextContainer Instance;
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

