using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Stellarplay.RockPaperScissor.Scripts.Timer
{
    public class SliderBasedTimerStrategy : TimerStrategy
    {
        [SerializeField] private float _duration = 2f;
        [SerializeField] private Slider _slider;
        [SerializeField] private UnityEvent _onTimerComplete;
        
        
        private float _startTime;
        private bool _isRunning;

        public override void StartTimer()
        {
            _startTime = Time.time;
            _isRunning = true;
            
            if (_slider != null)
                _slider.value = 0;
        }

        public override void StopTimer()
        {
            _isRunning = false;
        }

        public override void UpdateTimer()
        {
            if (!_isRunning)
                return;
            
            float progress = CalculateProgress();

            if (_slider != null)
                _slider.value = progress;

            if (progress >= 1.0f)
            {
                StopTimer();
                _onTimerComplete?.Invoke();
            }
        }

        private float CalculateProgress()
        {
            float elapsedTime = Time.time - _startTime;
            return Mathf.Clamp01(elapsedTime / _duration);
        }
    }
}