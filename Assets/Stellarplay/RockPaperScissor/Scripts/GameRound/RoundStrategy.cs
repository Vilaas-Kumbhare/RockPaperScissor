using System.Collections;
using Stellarplay.RockPaperScissor.Scripts.Timer;
using Stellarplay.RockPaperScissor.Scripts.UI;
using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.GameRound
{
    public class RoundStrategy : Round
    {
        [SerializeField] private UIManager _uiManager;
        [SerializeField] private TimerManager _timerManager;
        public override void StartNewRound()
        {
            StartCoroutine(StartRound());
        }

        public override void PlayerInteracted()
        {
            throw new System.NotImplementedException();
        }

        public override void TimeOut()
        {
            throw new System.NotImplementedException();
        }

        public override void ShowResult()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator StartRound()
        {
            _uiManager.UpdateMenuUI(true);
            yield return new WaitForSeconds(1.5f);
            
            _uiManager.UpdateMenuUI(true);
            _timerManager.StartTimer();
        }
        
        //IEnumerator 
    }
}

