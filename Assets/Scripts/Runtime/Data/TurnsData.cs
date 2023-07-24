using System;
using UnityEngine;

namespace Assets.Scripts.Runtime.Data
{
    [Serializable]
    public sealed class TurnsData
    {
        [SerializeField, Min(0)]
        private int turns;

        public int Turns
        {
            get => turns;
            private set => turns = value;
        }
    }
}
