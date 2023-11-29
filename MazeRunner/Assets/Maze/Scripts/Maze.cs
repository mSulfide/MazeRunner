using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze
{
    private MazeCell[,] _cells;

    public Maze(MazeCell[,] maze)
    {
        _cells = maze;
    }

    public static implicit operator MazeCell[,](Maze maze) => maze._cells; 
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
