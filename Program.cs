// each question have own branch

using System.Security.Cryptography.X509Certificates;

int OrangesRotting(int[][] grid)
{
    int rows = grid.Length;
    int columns = grid[0].Length;

    var queue = new Queue<(int,int)>();
    int fresh = 0;
    int time = 0;

    var directions = new (int, int)[] { (1,0),(-1,0),(0,1),(0,-1) };

    for (int i=0;i<rows;i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (grid[i][j] == 1)
            {
                fresh++;
            }
            else if (grid[i][j] == 2)
            {
                queue.Enqueue((i,j));
            }
        }
    }

    while (queue.Count > 0 && fresh > 0)
    {
        for(int i =0;i<queue.Count;i++)
        {
            var current = queue.Dequeue();
            foreach (var direction in directions)
            {
                (int x,int y) coord = (current.Item1 + direction.Item1, current.Item2 + direction.Item2);
                if (coord.x >= 0 && coord.x < rows && coord.y >= 0 && coord.y < columns && grid[coord.x][coord.y] == 1)
                {
                    grid[coord.x][coord.y] = 2;
                    queue.Enqueue(coord);
                    fresh--;
                }
            }
        }
        time++;
    }

    if (fresh > 0)
        return -1;
    else
        return time;
}