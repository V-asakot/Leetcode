// each question have own branch

int MaxAreaOfIsland(int[][] grid)
{
    int current, max = 0;
    int h = grid.Length;
    int w = grid[0].Length;

    void bfs(int i, int j)
    {
        var q = new Queue<(int x, int y)>();
        q.Enqueue((i, j));
        var directions = new (int x, int y)[] { (1, 0), (-1, 0), (0, 1), (0, -1) };
        while (q.Count > 0)
        {
            var cur = q.Dequeue();
            foreach (var direction in directions)
            {
                var pos = (x: cur.x + direction.x, y: cur.y + direction.y);
                if (pos.x < h && pos.x >= 0 && pos.y < w && pos.y >= 0 && grid[pos.x][pos.y] == 1)
                {
                    q.Enqueue(pos);
                    grid[pos.x][pos.y] = 2;
                    current++;
                }
            }
        }
        if (current > max) max = current;
    }

    for (int i = 0; i < h; i++)
    {
        for (int j = 0; j < w; j++)
        {
            if (grid[i][j] == 1)
            {
                current = 0;
                bfs(i, j);
            }
        }
    }
    return max;
}
