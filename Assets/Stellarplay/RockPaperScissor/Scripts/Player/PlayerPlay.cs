using UnityEngine;

namespace  Stellarplay.RockPaperScissor.Scripts.Player
{
    public abstract class PlayerPlay : MonoBehaviour, IPlayerPlay
    {
        public abstract void Play(int Id);
    }
}

