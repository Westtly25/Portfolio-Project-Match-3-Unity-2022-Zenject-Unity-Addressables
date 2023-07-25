using System;

[Serializable]
public class Cell
{
    private readonly int x;
    private readonly int y;

    public int X => x;
    public int Y => y;

    public Cell(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}