using Stellarplay.RockPaperScissor.Scripts.Interactions;
using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.GameRound
{
    public class RoundHandler : MonoBehaviour
    {
        [SerializeField] private Round _round;
        [SerializeField] private InteractionManager _interactionManager;

        public void SetRoundInteraction()
        {
            _interactionManager.SetInteraction(PlayerInteracted);
        }
        
        public void StartNewRound()
        {
            _round.StartNewRound();
        }

        private void PlayerInteracted(int id)
        {
            _round.PlayerInteracted(id);
            ShowResult();
        }

        public void RoundTimeOut()
        {
            _round.TimeOut();
        }

        private void ShowResult()
        {
            _round.ShowResult();
        }
    }
}

