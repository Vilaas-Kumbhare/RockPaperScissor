using System;
using System.Collections.Generic;
using UnityEngine;

namespace Stellarplay.RockPaperScissor.Scripts.DataContainer
{
    [CreateAssetMenu(fileName = "HandRelationData", menuName = "Hand/RelationData", order = 2)]
    public class HandRelationData : ScriptableObject
    {
        public List<HandRelations> HandRelationsList;
    }

    [Serializable]
    public class HandRelations
    {
        public Hand MainHand;
        public List<Hand> CanDefeat;
    }
}

