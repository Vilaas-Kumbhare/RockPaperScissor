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
            yield return new WaitForSeconds(1.5f);
            
            _uiManager.UpdateMenuUI(true);
            _timerManager.StartTimer();
        }

        IEnumerator TimeOutSequence()
        {
            _uiManager.UpdateMenuUI(true,UIManager.FIRST_CONDITION);
            yield return new WaitForSeconds(2f);
            _uiManager.UpdateMenuUI(true);
        }

        IEnumerator ShowSelectedHandsAndResult()
        {
            _uiManager.UpdateMenuUI(true);
            yield return new WaitForSeconds(1.5f);
            _uiManager.UpdateMenuUI(true,(int)_result);
            
            if(_result == RoundResult.Win)
                _scoreManager.UpdateScore();
            yield return new WaitForSeconds(1.5f);

            if (_result == RoundResult.Win || _result == RoundResult.Draw)
                StartCoroutine(StartRound());
            else
            {
                _uiManager.UpdateMenuUI(true);
            }
        }
    }
}

