using System;
using System.Collections.Generic;
using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.UI
{
    [Serializable]
    public class Screen
    {
        [SerializeField] private string _screenName;
        [SerializeField] private string[] _nextScreenName;
        [SerializeField] private List<UICanvasObject> _uiCanvasObjects;

        public string ScreenName => _screenName;
        public string[] NextScreenName => _nextScreenName;

        public void UpdateCurrentScreen()
        {
            foreach (var uiCanvasObject in _uiCanvasObjects)
            {
                if (uiCanvasObject.ScreenObject == null)
                {
                    Debug.LogWarning($"ScreenObject is missing in screen '{_screenName}'.");
                    continue;
                }

                uiCanvasObject.ScreenObject.SetActive(uiCanvasObject.NeedEnabled);
            }
        }
    }

    [Serializable]
    public class UICanvasObject
    {
        [SerializeField] private GameObject _screenObject;
        [SerializeField] private bool _needEnabled;

        public GameObject ScreenObject => _screenObject;
        public bool NeedEnabled => _needEnabled;
    }
}

