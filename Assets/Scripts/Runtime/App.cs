using UnityEngine;

namespace Assets.Scripts.Runtime
{
    public class App : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}
