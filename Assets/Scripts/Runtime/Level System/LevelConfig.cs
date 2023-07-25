using System;
using UnityEngine;

namespace Assets.Scripts.Runtime
{
    [Serializable]
    public class LevelConfig
    {
        [SerializeField, Range(0, int.MaxValue)]
        private int id;
        [SerializeField, Range(0, 100)]
        private int requiredTurns;

        [SerializeField, Range(4, 20)]
        private int width;
        [SerializeField, Range(4, 20)]
        private int height;
    }
}
