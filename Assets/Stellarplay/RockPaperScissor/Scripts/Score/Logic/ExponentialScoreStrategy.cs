using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.Score
{
    [CreateAssetMenu(fileName = "ExponentialScoreStrategy", menuName = "Score Strategies/Exponential")]
    public class ExponentialScoreStrategy : ScoreStrategy
    {
        public override int CalculateScore(int baseScore, int multiplier)
        {
            return (int)Mathf.Pow(baseScore, multiplier);
        }
    }
}
