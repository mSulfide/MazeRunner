using UnityEngine;

public class MazeSpawner : MonoBehaviour
{
    [SerializeField] private Vector2Int _mazeSize;
    public Cell CellPrefab;
    public Vector3 CellSize = new Vector3(1,1,0);

    public Maze maze;

    private void Start()
    {
        MazeGenerator generator = new MazeGenerator();
        maze = generator.GenerateMaze(_mazeSize);

        MazeCell[,] cells = maze;

        for (int x = 0; x < cells.GetLength(0); x++)
        {
            for (int y = 0; y < cells.GetLength(1); y++)
            {
                Cell c = Instantiate(CellPrefab, new Vector3(x * CellSize.x, y * CellSize.y, y * CellSize.z), Quaternion.identity, transform);
                c.name = $"{CellPrefab.name}({x}, {y})";

                c.WallLeft.SetActive(cells[x, y].WallLeft);
                c.WallBottom.SetActive(cells[x, y].WallBottom);
            }
        }
    }
}