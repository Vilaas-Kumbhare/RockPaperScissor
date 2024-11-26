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
            _savedHighScore.text = _highScore.ToString();
        }


        public override void UpdateScore(int score)
        {
            foreach (TextMeshProUGUI scoreUI in _scoreUITexts)
            {
                scoreUI.text = score.ToString();
            }

            _highScore = Mathf.Max(score, _highScore);
            SetHighScore(_highScore);
        }

        private void SetHighScore(int highScore)
        {
            _savedHighScore.text = highScore.ToString();
            PlayerPrefs.SetInt("highScore", highScore);
        }
    }
}
