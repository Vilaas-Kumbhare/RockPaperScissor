using TMPro;
using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.Score
{
    public class TextMeshProUIScoreStrategy : ScoreUIStrategy
    {
        [SerializeField] 
        private TextMeshProUGUI[] _scoreUITexts;
        
        
        public override void UpdateScore(int score)
        {
            foreach (TextMeshProUGUI scoreUI in _scoreUITexts)
            {
                scoreUI.text = score.ToString();
            }
        }
    }
}
