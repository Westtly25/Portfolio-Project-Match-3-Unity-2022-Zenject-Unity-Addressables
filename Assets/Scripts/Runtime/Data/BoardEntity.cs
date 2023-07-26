using System;
using UnityEngine;

namespace Assets.Scripts.Runtime.Data
{
    public enum PotionColor : byte
    {
        Red,
        Blue,
        Orange,
    }

    [Serializable]
    public class BoardEntity : MonoBehaviour
    {
    }

    public class Potion : BoardEntity
    {
        public PotionColor color;

        public PotionColor PotionColor => color;
    }
}
