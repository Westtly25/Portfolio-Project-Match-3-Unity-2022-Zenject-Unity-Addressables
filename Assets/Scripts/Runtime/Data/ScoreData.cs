using System;
using UnityEngine;

namespace Assets.Scripts.Runtime.Data
{
    [Serializable]
    public class ScoreData
    {
        [SerializeField, Min(0)]
        private int score;

        public int Score
        {
            get => score;
            private set => score = value;
        }
    }
}