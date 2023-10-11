using System;
using System.Text;

bool Exist(char[][] board, string word) 
{
    int rows = board.Length, columns = board[0].Length;
    var set = new HashSet<(int,int)>();

    bool DFS(int r,int c ,int i)
    {
        if(i == word.Length)
        {
            return true;
        }

        if(r < 0 || c <  0 || r >= rows || c >= columns || word[i] != board[r][c] || set.Contains((r,c)))
        {
            return false;
        }

        set!.Add((r,c));
        var res  = DFS(r+1,c ,i+1) || DFS(r-1,c ,i+1) || DFS(r,c+1 ,i+1) || DFS(r,c-1 ,i+1);
        set!.Remove((r,c));
        return res;
    }

    for(int i=0; i < rows ;i++)
    {
        for(int j=0; j < columns ;j++)
        {
            if(DFS(i,j,0))
            {
                return true;
            }
        }
    }

    return false;
}