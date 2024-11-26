using System;
using UnityEngine;
using UnityEngine.Events;

namespace  Stellarplay.RockPaperScissor.Scripts.Interactions
{
    [Serializable]
    public class InteractionManager : MonoBehaviour
    {
        [SerializeField] private Interaction _interaction;

        public void SetInteraction(UnityAction<int> interactionCallback)
        {
            _interaction.SetInteraction(interactionCallback);
        }

        public void EnableInteraction(bool enable)
        {
            _interaction.EnableInteraction(enable);
        }
    }
}

