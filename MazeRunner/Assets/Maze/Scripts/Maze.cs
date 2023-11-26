using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze
{
    public MazeCell[,] Cells;
    public Vector2Int FinishPosition;
}

public class MazeCell
{
    public int X;
    public int Y;

    public bool WallLeft = true;
    public bool WallBottom = true;

    public bool Visited;
    public int DistanceFromStart;
}
