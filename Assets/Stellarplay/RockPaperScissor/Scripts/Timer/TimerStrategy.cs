using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.Timer
{
    public abstract class TimerStrategy : MonoBehaviour, ITimer
    {
        public abstract void StartTimer();
        public abstract void StopTimer();
        public abstract void UpdateTimer();
    }
}