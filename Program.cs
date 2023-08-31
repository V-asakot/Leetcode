// each question have own branch
using System.ComponentModel.Design;
using System.Data.Common;
using System.Security.Cryptography;

IList<IList<int>> PacificAtlantic(int[][] heights)
{
    int height = heights.Length, width = heights[0].Length;
    var pacific = new HashSet<(int, int)>();
    var atlantic = new HashSet<(int, int)>();

    void DFS(int r, int c, HashSet<(int, int)> visit, int prevValue)
    {
        if (visit.Contains((r, c)) || r < 0 || c < 0 || r == height || c == width || heights[r][c] < prevValue) return;
        visit.Add((r, c));
        DFS(r + 1, c, visit, heights[r][c]);
        DFS(r - 1, c, visit, heights[r][c]);
        DFS(r, c + 1, visit, heights[r][c]);
        DFS(r, c - 1, visit, heights[r][c]);
    }

    int x = 0;
    for (; x < width; x++)
    {
        DFS(0, x, pacific, heights[0][x]);
        DFS(height - 1, x, atlantic, heights[height - 1][x]);
    }

    for (int y = 0; y < height; y++)
    {
        DFS(y, 0, pacific, heights[y][0]);
        DFS(y, width - 1, atlantic, heights[y][x - 1]);
    }

    var res = new List<IList<int>>();
    foreach (var pair in pacific)
    {
        if (atlantic.Contains(pair)) res.Add(new List<int>() { pair.Item1, pair.Item2 });
    }
    return res;
}