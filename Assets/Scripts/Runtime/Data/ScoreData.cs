using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SocialPlatforms.Impl;
using Zenject;
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