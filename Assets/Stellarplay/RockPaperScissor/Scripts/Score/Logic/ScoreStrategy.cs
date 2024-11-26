using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.Score
{
    public abstract class ScoreStrategy : ScriptableObject, IScore
    {
        public abstract int CalculateScore(int baseScore, int multiplier);
    }
}
