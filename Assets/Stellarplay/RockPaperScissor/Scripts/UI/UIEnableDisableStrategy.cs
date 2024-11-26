using System.Collections.Generic;
using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.UI
{
    public class UIEnableDisableStrategy : UIScreen
    {
        [SerializeField] 
        private string _currentScreen;
        [SerializeField] 
        private List<Screen> _uiScreens;

        private Dictionary<string, Screen> _dicSavedScreens;

        public override void InitUI()
        {
            _dicSavedScreens = new Dictionary<string, Screen>();
            foreach (Screen screen in _uiScreens)
            {
                _dicSavedScreens.Add(screen.ScreenName,screen);
            }
        }

        public override void UpdateUI(bool nextScreen, int conditionalNextScreen)
        {
            if(nextScreen)
                _currentScreen = _dicSavedScreens[_currentScreen].NextScreenName[conditionalNextScreen];
            
            _dicSavedScreens[_currentScreen].UpdateCurrentScreen();
        }
    }
}

