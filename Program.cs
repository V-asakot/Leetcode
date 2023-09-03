// each question have own branch
void Solve(char[][] board)
{
    int rows = board.Length, columns = board[0].Length;

    void DFS(int x, int y)
    {
        if (x < 0 || y < 0 || x == rows || y == columns || board[x][y] != 'O') return;
        board[x][y] = '+';
        DFS(x + 1, y);
        DFS(x - 1, y);
        DFS(x, y + 1);
        DFS(x, y - 1);
    }

    for (int x = 0; x < rows; x++)
    {
        DFS(x, 0);
        DFS(x, columns - 1);
    }

    for (int y = 1; y < columns - 1; y++)
    {
        DFS(0, y);
        DFS(rows - 1, y);
    }

    for (int x = 0; x < rows; x++)
    {
        for (int y = 0; y < columns; y++)
        {
            if (board[x][y] == '+')
            {
                board[x][y] = 'O';
            }
            else
            {
                board[x][y] = 'X';
            }
        }
    }
}