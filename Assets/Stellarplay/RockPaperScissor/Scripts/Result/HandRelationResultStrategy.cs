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
            HandRelations playerHand = _handRelationData.HandRelationsList[_playerController.PlayerPlayId];
            HandRelations aiHand = _handRelationData.HandRelationsList[_aiController.AiPlayId];

            RoundResult roundResult = RoundResult.Draw;
            _winningHand.sprite = playerHand.MainHand.HandSprite;

            if (playerHand == aiHand)
            {
                roundResult = RoundResult.Draw;
                _winningHand.sprite = playerHand.MainHand.HandSprite;
            }
            else
            {
                foreach (Hand hand in playerHand.CanDefeat)
                {
                    if (hand == aiHand.MainHand)
                    {
                        roundResult = RoundResult.Win;
                        _winningHand.sprite = playerHand.MainHand.HandSprite;
                        break;
                    }
                }
                
                foreach (Hand hand in aiHand.CanDefeat)
                {
                    if (hand == playerHand.MainHand)
                    {
                        roundResult = RoundResult.Loss;
                        _winningHand.sprite = aiHand.MainHand.HandSprite;
                        break;
                    }
                }
            }
            return roundResult;
        }
    }
}

