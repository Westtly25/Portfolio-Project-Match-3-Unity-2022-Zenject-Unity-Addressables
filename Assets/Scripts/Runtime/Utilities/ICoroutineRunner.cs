using UnityEngine;
using System.Collections;

namespace Assets.Scripts.Runtime.Utilities
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator coroutine);
    }
}
