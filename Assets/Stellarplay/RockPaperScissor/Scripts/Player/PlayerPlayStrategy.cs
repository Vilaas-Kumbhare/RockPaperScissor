using Stellarplay.RockPaperScissor.Scripts.DataContainer;
using UnityEngine;
using UnityEngine.UI;

namespace  Stellarplay.RockPaperScissor.Scripts.Player
{
    public class PlayerPlayStrategy : PlayerPlay
    {
        [SerializeField] private HandRelationData _handRelationData;
        [SerializeField] private Image _handImage;

        public override void Play(int id)
        {
            _handImage.sprite = _handRelationData.HandRelationsList[id].MainHand.HandSprite;
        }
    }
}

