using System.Collections.Generic;
using Stellarplay.RockPaperScissor.Scripts.DataContainer;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace  Stellarplay.RockPaperScissor.Scripts.Interactions
{
    public class UIButtonInteractionStrategy : Interaction
    {
        [SerializeField] private Button[] _interactionButtons;
        [SerializeField] private HandRelationData _handRelationsDataAsset;
        private UnityAction<int> _interactionCallback;

        private void Awake()
        {
            if (_interactionButtons == null || _interactionButtons.Length == 0)
            {
                Debug.LogError("Interaction buttons are not assigned.");
            }

            if (_handRelationsDataAsset == null)
            {
                Debug.LogError("HandRelationsDataAsset is not assigned.");
            }
        }

        public override void SetInteraction(UnityAction<int> interactionCallback)
        {
            _interactionCallback = interactionCallback;

            if (_handRelationsDataAsset == null || _interactionButtons == null) return;

            List<HandRelations> handRelationsList = _handRelationsDataAsset.HandRelationsList;
            for (int i = 0; i < _interactionButtons.Length; i++)
            {
                if (i < handRelationsList.Count)
                {
                    int buttonID = i;
                    _interactionButtons[i].onClick.RemoveAllListeners();
                    _interactionButtons[i].onClick.AddListener(() => InteractionDone(buttonID));
                    _interactionButtons[i].image.sprite = handRelationsList[i].MainHand.HandSprite;
                }
                else
                {
                    _interactionButtons[i].gameObject.SetActive(false);
                }
            }
        }

        public override void EnableInteraction(bool enable)
        {
            foreach (Button button in _interactionButtons)
            {
                button.gameObject.SetActive(enable);
            }
        }

        public override void InteractionDone(int buttonID)
        {
            if (buttonID < 0 || buttonID >= _interactionButtons.Length)
            {
                Debug.LogError($"Invalid button ID: {buttonID}");
                return;
            }

            Debug.Log($"Button {buttonID} ('{_interactionButtons[buttonID].name}') was pressed.");
            _interactionCallback?.Invoke(buttonID);
        }
    }
}

