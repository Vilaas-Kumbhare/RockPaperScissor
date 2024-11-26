using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.GameRound
{
    public abstract class Round : MonoBehaviour, IRound
    {
        public abstract void StartNewRound();
        public abstract void PlayerInteracted();
        public abstract void TimeOut();
        public abstract void ShowResult();

    }
}

