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

