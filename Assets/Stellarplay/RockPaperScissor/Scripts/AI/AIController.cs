using System;
using UnityEngine;

namespace  Stellarplay.RockPaperScissor.Scripts.AI
{
    [Serializable]
    public class AIController : MonoBehaviour
    {
        [SerializeField] private AIPlay _aiPlay;
        private int _aiPlayId;

        public int AiPlayId => _aiPlayId;

        private void Awake()
        {
            if (_aiPlay == null)
                Debug.LogError("AIPlay strategy is not assigned.");
        }
        public void Play()
        {
            _aiPlay.Play(SetAIPlayId);
        }
        private void SetAIPlayId(int id)
        {
            _aiPlayId = id;
        }
    }
    
}

