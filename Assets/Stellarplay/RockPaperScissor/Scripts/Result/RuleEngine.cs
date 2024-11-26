using System;
using UnityEngine;

namespace  Stellarplay.RockPaperScissor.Scripts.Result
{
    [Serializable]
    public class RuleEngine : MonoBehaviour
    {
        [SerializeField] private Result _result;
        
        public RoundResult Evaluate()
        {
            return _result.Evaluate();
        }
    }
    
    public enum RoundResult { Win, Loss, Draw }
}

