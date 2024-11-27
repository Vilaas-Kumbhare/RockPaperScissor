using Stellarplay.RockPaperScissor.Scripts.DataContainer;
using UnityEngine;
using UnityEngine.UI;

namespace  Stellarplay.RockPaperScissor.Scripts.Player
{
    public class PlayerPlayStrategy : PlayerPlay
    {
        [SerializeField] private HandRelationData _handRelationData;
        [SerializeField] private Image _handImage;

        private void Awake()
        {
            if (_handRelationData == null) Debug.LogError("HandRelationData is not assigned.");
            if (_handImage == null) Debug.LogError("HandImage is not assigned.");
        }
        
        public override void Play(int id)
        {
            _handImage.sprite = _handRelationData.HandRelationsList[id].MainHand.HandSprite;
        }
    }
}

