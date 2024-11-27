using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private UIScreen _uiScreenUI;
        
        private void Start()
        {
            _uiScreenUI.InitUI();
            UpdateMenuUI(false);
        }

        public void UpdateMenuUI(bool nextScreen, int conditionalScreen = 0)
        {
            _uiScreenUI.UpdateUI(nextScreen, conditionalScreen);
        }
    }
}

