using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.Score
{
    public abstract class ScoreUIStrategy : MonoBehaviour, IScoreUI
    {
        public abstract void UpdateScore(int score);
    }
}
