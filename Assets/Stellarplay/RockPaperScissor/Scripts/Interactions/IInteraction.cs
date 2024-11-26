using UnityEngine.Events;

namespace  Stellarplay.RockPaperScissor.Scripts.Interactions
{
    public interface IInteraction
    {
        public void SetInteraction(UnityAction<int> interactionCallback);
        public void EnableInteraction(bool enable);
        public void InteractionDone(int buttonID);
    }
}

