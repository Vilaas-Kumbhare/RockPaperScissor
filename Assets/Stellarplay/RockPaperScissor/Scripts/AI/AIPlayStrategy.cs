
using Stellarplay.RockPaperScissor.Scripts.DataContainer;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace  Stellarplay.RockPaperScissor.Scripts.AI
{
    public class AIPlayStrategy : AIPlay
    {
        [SerializeField] private HandRelationData _handRelationData;
        [SerializeField] private Image _aiHandImage;

        public override void Play(UnityAction<int> callback)
        {
            if (_handRelationData == null || _handRelationData.HandRelationsList.Count == 0)
            {
                Debug.LogError("HandRelationData is not properly configured.");
                callback?.Invoke(-1);
                return;
            }
            
            int id = Random.Range(0, _handRelationData.HandRelationsList.Count);

            if (_aiHandImage != null)
                _aiHandImage.sprite = _handRelationData.HandRelationsList[id].MainHand.HandSprite;
            
            callback?.Invoke(id);
        }
    }
}

