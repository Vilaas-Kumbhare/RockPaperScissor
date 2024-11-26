using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.Timer
{
    public class TimerManager : MonoBehaviour
    {
        [SerializeField] 
        private TimerStrategy _timerStrategy;
        
        
        /// <summary>
        /// Property to dynamically assign or retrieve the current timer strategy.
        /// TimerManager timerManager = GetComponent<TimerManager>();
        /// timerManager.TimerStrategy = new SliderBasedTimerStrategy();
        /// timerManager.StartTimer();
        /// </summary>
        public TimerStrategy TimerStrategy
        {
            get => _timerStrategy;
            set
            {
                _timerStrategy = value;
                if (_timerStrategy == null)
                    Debug.LogWarning("TimerStrategy is set to null.");
            }
        }

        public void StartTimer()
        {
            if (_timerStrategy == null)
            {
                Debug.LogError("TimerStrategy is not assigned. Cannot start timer.");
                return;
            }
            _timerStrategy.StartTimer();
        }

        public void StopTimer()
        {
            if (_timerStrategy == null)
            {
                Debug.LogError("TimerStrategy is not assigned. Cannot stop timer.");
                return;
            }
            _timerStrategy.StopTimer();
        }

        private void Update()
        {
            if (_timerStrategy == null)
                return;
            _timerStrategy.UpdateTimer();
        }
    }
}