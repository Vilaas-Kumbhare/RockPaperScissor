using UnityEngine;

namespace  Stellarplay.RockPaperScissor.Scripts.Result
{
    public abstract class Result : MonoBehaviour, IResult
    {
        public abstract RoundResult Evaluate();
    }
}

