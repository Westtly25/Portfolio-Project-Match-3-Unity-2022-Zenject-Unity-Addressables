using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BoardModel
{
    [SerializeField, Range(4, 40)]
    private int width;
    [SerializeField, Range(4, 40)]
    private int height;

    [SerializeField]
    private Cell[][] nodes;
}

public class Board : MonoBehaviour
{
    
}

[Serializable]
public class Cell
{

}
