using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.DataContainer
{
    [CreateAssetMenu(fileName = "HandData", menuName = "Hand/Data", order = 1)]
    public class Hand : ScriptableObject
    {
        public string HandName;
        public Sprite HandSprite;
    }
}

