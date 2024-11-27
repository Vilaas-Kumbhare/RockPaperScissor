using System;
using TMPro;
using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.Score
{
    public class TextMeshProUIScoreStrategy : ScoreUIStrategy
    {
        [SerializeField] private TextMeshProUGUI[] _scoreUITexts;

        [SerializeField] private TextMeshProUGUI _savedHighScore;

        private int _highScore;

        private void Start()
        {
            _highScore = PlayerPrefs.GetInt("highScore", 0);
            UpdateHighScoreUI(_highScore);
        }


        public override void UpdateScore(int score)
        {
            foreach (TextMeshProUGUI scoreUI in _scoreUITexts)
            {
                scoreUI.text = score.ToString();
            }

            _highScore = Mathf.Max(score, _highScore);
            SaveHighScore(_highScore);
            UpdateHighScoreUI(_highScore);
        }

        private void UpdateHighScoreUI(int highScore)
        {
            _savedHighScore.text = highScore.ToString();
        }

        private void SaveHighScore(int highScore)
        {
            PlayerPrefs.SetInt("highScore", highScore);
        }
    }
}
