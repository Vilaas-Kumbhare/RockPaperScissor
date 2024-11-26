namespace Stellarplay.RockPaperScissor.Scripts.GameRound
{
    public interface IRound
    {
        public void StartNewRound();
        public void PlayerInteracted();
        public void TimeOut();
        public void ShowResult();
    }
}

