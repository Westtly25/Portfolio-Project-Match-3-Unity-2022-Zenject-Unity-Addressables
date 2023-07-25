using UnityEngine;
using System.Collections;

namespace Assets.Scripts.Runtime.Utilities
{
    public class CoroutineRunner : MonoBehaviour, ICoroutineRunner
    {
        public new Coroutine StartCoroutine(IEnumerator coroutine)
        {
            Coroutine toRun = base.StartCoroutine(coroutine);
            return toRun;
        }

        public new void StopCoroutine(IEnumerator coroutine)
        {
            if (WasDisposed())
                return;

            base.StopCoroutine(coroutine);
        }

        private bool WasDisposed() =>
            this == null;

    }
}