using System.Collections;
using UnityEngine;
using Containers;
using UnityEngine.UI;

namespace GameUI
{
    public class DeathMenu 
    {
        private Canvas DeathMenuCanvas = CanvasContainer.Instance.GetItemByIndex(0);

        public void ShowDeathMenu()
        {
            DeathMenuCanvas.enabled = true;
            Time.timeScale = 0;
        }

        public void HideDeathMenu()
        {
            DeathMenuCanvas.enabled = false;
            Time.timeScale = 1;
        }

    }
}