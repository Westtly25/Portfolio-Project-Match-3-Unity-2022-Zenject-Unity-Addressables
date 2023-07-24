using System;
using UnityEngine;

[Serializable]
public sealed class BoardData
{
    [SerializeField, Range(4, 40)]
    private int width;
    [SerializeField, Range(4, 40)]
    private int height;

    [SerializeField]
    private Cell[][] nodes;
}
