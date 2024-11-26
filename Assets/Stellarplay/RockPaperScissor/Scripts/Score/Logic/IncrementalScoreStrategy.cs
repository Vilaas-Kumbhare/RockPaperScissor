using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.Score
{
    [CreateAssetMenu(fileName = "IncrementalScoreStrategy", menuName = "Score Strategies/Incremental")]
    public class IncrementalScoreStrategy : ScoreStrategy
    {
        public override int CalculateScore(int baseScore, int multiplier)
        {
            return baseScore * multiplier;
        }
    }
}
