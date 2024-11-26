namespace Stellarplay.RockPaperScissor.Scripts.UI
{
    public interface IUIScreen
    {
        public void InitUI();
        public void UpdateUI(bool nextScreen, int conditionalNextScreen);
    }
}

