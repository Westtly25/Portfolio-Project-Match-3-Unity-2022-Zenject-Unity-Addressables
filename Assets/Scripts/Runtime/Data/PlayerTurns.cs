using System;
using UnityEngine;

namespace Assets.Scripts.Runtime.Data
{
    [Serializable]
    public sealed class PlayerTurns
    {
        [SerializeField, Min(0)]
        private int turns;

        public int Turns => turns;

        public void Increase(int value)
        {
            if (value > 0)
                turns += value;
        }

        public void Decrease(int value)
        {
            if (value < 0)
                turns -= value;
        }
    }
}
