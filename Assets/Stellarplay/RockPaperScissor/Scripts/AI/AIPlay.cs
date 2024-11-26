using UnityEngine;
using UnityEngine.Events;

namespace  Stellarplay.RockPaperScissor.Scripts.AI
{
    public abstract class AIPlay : MonoBehaviour, IAIPlay
    {
        public abstract void Play(UnityAction<int> callback);
    }
}

