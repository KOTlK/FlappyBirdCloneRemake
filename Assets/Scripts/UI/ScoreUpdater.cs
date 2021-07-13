using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Containers;
using UnityEngine.UI;

namespace GameUI
{
    public class ScoreUpdater
    {
        private Text Text => UITextContainer.Instance.GetItemByIndex(0);

        public void UpdateScore(int currentScore)
        {
            Text.text = $"Score: {currentScore}";
        }
    }
}

