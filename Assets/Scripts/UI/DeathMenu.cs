using System.Collections;
using UnityEngine;
using Containers;
using UnityEngine.UI;
using GameLogic;

namespace GameUI
{
    public class DeathMenu 
    {
        private Canvas DeathMenuCanvas = CanvasContainer.Instance.GetItemByIndex(0);
        private Text CurrentScore = UITextContainer.Instance.GetItemByIndex(2);
        private Text BestScore = UITextContainer.Instance.GetItemByIndex(3);

        public void ShowDeathMenu(int score)
        {
            CurrentScore.text = $"Your Score: {score}";
            BestScore.text = $"Best score: {Saves.GetBestScore()}";
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