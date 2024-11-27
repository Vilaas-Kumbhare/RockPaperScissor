using System.Collections;
using Stellarplay.RockPaperScissor.Scripts.AI;
using Stellarplay.RockPaperScissor.Scripts.Player;
using Stellarplay.RockPaperScissor.Scripts.Result;
using Stellarplay.RockPaperScissor.Scripts.Score;
using Stellarplay.RockPaperScissor.Scripts.Timer;
using Stellarplay.RockPaperScissor.Scripts.UI;
using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.GameRound
{
    public class RoundStrategy : Round
    {
        [SerializeField] private UIManager _uiManager;
        [SerializeField] private TimerManager _timerManager;
        [SerializeField] private PlayerController _playerController;
        [SerializeField] private AIController _aiController;
        [SerializeField] private RuleEngine _ruleEngine;
        [SerializeField] private ScoreManager _scoreManager;
        
        private RoundResult _result;
        private Coroutine _currentCoroutine;
        private int _timeOutCondition = 0;
        
        private const float ScreenPersistTimeDelay = 1.5f;
        
        private void Awake()
        {
            if (_uiManager == null) Debug.LogError("UIManager is not assigned in RoundStrategy.");
            if (_timerManager == null) Debug.LogError("TimerManager is not assigned in RoundStrategy.");
            if (_playerController == null) Debug.LogError("PlayerController is not assigned in RoundStrategy.");
            if (_aiController == null) Debug.LogError("AIController is not assigned in RoundStrategy.");
            if (_ruleEngine == null) Debug.LogError("RuleEngine is not assigned in RoundStrategy.");
            if (_scoreManager == null) Debug.LogError("ScoreManager is not assigned in RoundStrategy.");
        }
        public override void StartNewRound()
        {
            _scoreManager.InitScore();
            StartCoroutine(StartRound());
        }

        public override void PlayerInteracted(int id)
        {
            _timerManager.StopTimer();
            _playerController.Play(id);
            _aiController.Play();
        }

        public override void TimeOut()
        {
            StartCoroutine(TimeOutSequence());
        }

        public override void ShowResult()
        {
            _result = _ruleEngine.Evaluate();
            StartCoroutine(ShowSelectedHandsAndResult());
        }

        IEnumerator StartRound()
        {
            _uiManager.UpdateMenuUI(true);
            yield return new WaitForSeconds(ScreenPersistTimeDelay);
            
            _uiManager.UpdateMenuUI(true);
            _timerManager.StartTimer();
        }

        IEnumerator TimeOutSequence()
        {
            _uiManager.UpdateMenuUI(true,_timeOutCondition);
            yield return new WaitForSeconds(ScreenPersistTimeDelay);
            _uiManager.UpdateMenuUI(true);
        }

        IEnumerator ShowSelectedHandsAndResult()
        {
            _uiManager.UpdateMenuUI(true);
            yield return new WaitForSeconds(ScreenPersistTimeDelay);
            _uiManager.UpdateMenuUI(true,(int)_result);

            switch (_result)
            {
                case RoundResult.Win:
                    _scoreManager.UpdateScore();
                    yield return new WaitForSeconds(ScreenPersistTimeDelay);
                    StartCoroutine(StartRound());
                    break;

                case RoundResult.Draw:
                    yield return new WaitForSeconds(ScreenPersistTimeDelay);
                    StartCoroutine(StartRound());
                    break;

                case RoundResult.Loss:
                    yield return new WaitForSeconds(ScreenPersistTimeDelay);
                    _uiManager.UpdateMenuUI(true);
                    break;
            }
        }
    }
}

