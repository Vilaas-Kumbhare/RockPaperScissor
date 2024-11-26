using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.Score
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] 
        private ScoreStrategy _scoreStrategy;

        [SerializeField] 
        private ScoreUIStrategy _scoreUIStrategy;


        private int _currentScore;
        private int _currentMultiplier;

        private void Start()
        {
            InitScore();
        }

        public void UpdateScore()
        {
            if (_scoreStrategy != null)
            {
                _currentScore = _scoreStrategy.CalculateScore(_currentScore, _currentMultiplier);
                UpdateScoreUI(_currentScore);
                _currentMultiplier++;
            }
        }

        private void UpdateScoreUI(int score)
        {
            if(_scoreUIStrategy != null)
                _scoreUIStrategy.UpdateScore(score);
        }

        public void InitScore()
        {
            _currentScore = 0;
            _currentMultiplier = 0;
            UpdateScore();
        }
    }
}
