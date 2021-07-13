using System.Collections;
using UnityEngine;

namespace GameLogic
{
    public class Saves : MonoBehaviour
    {
        private static string _bestScore = "Best Score";
        private void Awake()
        {
            if (PlayerPrefs.HasKey(_bestScore) == false)
            {
                PlayerPrefs.SetInt(_bestScore, 0);
            }
        }

        public static void SaveBestScore(int score)
        {
            if (PlayerPrefs.GetInt(_bestScore) < score)
            {
                PlayerPrefs.SetInt(_bestScore, score);
            }
        }

        public static int GetBestScore()
        {
            return PlayerPrefs.GetInt(_bestScore);
        }
    }
}