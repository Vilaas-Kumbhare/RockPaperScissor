using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.UI
{
    public abstract class UIScreen : MonoBehaviour, IUIScreen
    {
        public abstract void InitUI();
        public abstract void UpdateUI(bool nextScreen, int conditionalNextScreen);
    }
}

