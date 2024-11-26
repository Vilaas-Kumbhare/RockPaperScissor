using System;
using Stellarplay.RockPaperScissor.Scripts.GameRound;
using UnityEngine;

namespace  Stellarplay.RockPaperScissor.Scripts.GameManager
{
    [Serializable]
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private RoundHandler _roundHandler;
        public void StartGame()
        {
            _roundHandler.SetRoundInteraction();
            _roundHandler.StartNewRound();
        }
    }
}

