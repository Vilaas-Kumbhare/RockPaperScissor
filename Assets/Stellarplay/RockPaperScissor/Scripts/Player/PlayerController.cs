using System;
using UnityEngine;

namespace  Stellarplay.RockPaperScissor.Scripts.Player
{
    [Serializable]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerPlay _playerPlay;
        private int _playerPlayId;

        public int PlayerPlayId => _playerPlayId;

        public void Play(int playId)
        {
            _playerPlay.Play(playId);
            _playerPlayId = playId;
        }
    }
    
}

