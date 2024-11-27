using Stellarplay.RockPaperScissor.Scripts.AI;
using Stellarplay.RockPaperScissor.Scripts.DataContainer;
using Stellarplay.RockPaperScissor.Scripts.Player;
using UnityEngine;
using UnityEngine.UI;

namespace  Stellarplay.RockPaperScissor.Scripts.Result
{
    public class HandRelationResultStrategy : Result
    {
        [SerializeField] private HandRelationData _handRelationData;
        [SerializeField] private PlayerController _playerController;
        [SerializeField] private AIController _aiController;

        [SerializeField] private Image _winningHand;
        public override RoundResult Evaluate()
        {
            if (_handRelationData == null || _playerController == null || _aiController == null)
            {
                Debug.LogError("Dependencies are not assigned.");
                return RoundResult.Draw;
            }

            HandRelations playerHand = _handRelationData.HandRelationsList[_playerController.PlayerPlayId];
            HandRelations aiHand = _handRelationData.HandRelationsList[_aiController.AiPlayId];

            if (playerHand == aiHand)
                return RoundResult.Draw;

            if (playerHand.CanDefeat.Contains(aiHand.MainHand))
            {
                SetWinningHand(playerHand.MainHand.HandSprite);
                return RoundResult.Win;
            }

            SetWinningHand(aiHand.MainHand.HandSprite);
            return RoundResult.Loss;
        }

        private void SetWinningHand(Sprite winningSprite)
        {
            if (_winningHand != null)
                _winningHand.sprite = winningSprite;
        }
    }
}

