using UnityEngine;
using UnityEngine.Events;

namespace  Stellarplay.RockPaperScissor.Scripts.Interactions
{
    public abstract class Interaction : MonoBehaviour, IInteraction
    {
        public abstract void SetInteraction(UnityAction<int> interactionCallback);
        public abstract void EnableInteraction(bool enable);
        public abstract void InteractionDone(int buttonID);
    }
}

