using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private UIScreen _uiScreenUI;
        
        public const int DEFAULT_CONDITION = 0;
        public const int FIRST_CONDITION = 1;

        private void Start()
        {
            _uiScreenUI.InitUI();
            UpdateMenuUI(false);
        }

        public void UpdateMenuUI(bool nextScreen, int conditionalScreen = DEFAULT_CONDITION)
        {
            _uiScreenUI.UpdateUI(nextScreen, conditionalScreen);
        }
    }
}
