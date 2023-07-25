using UnityEngine;

namespace Assets.Scripts.Runtime.Level_System
{
    [CreateAssetMenu(menuName = "Match3 / LevelsConfigsContainer", fileName = "Levels Configs Container", order = 1)]
    public class LevelsConfigsContainer : ScriptableObject
    {
        [SerializeField]
        public LevelConfig[] levelConfigs;
    }
}
