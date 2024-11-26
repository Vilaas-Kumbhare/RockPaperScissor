using UnityEngine.Events;

namespace  Stellarplay.RockPaperScissor.Scripts.AI
{
    public interface IAIPlay
    {
        public void Play(UnityAction<int> callback);
    }
}

