public class Solution 
{
    private char[][] grid;

    public int NumIslands(char[][] grid) 
    {
        this.grid = grid;

        int numIslands = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == '1')
                {
                    DFS(i, j);
                    numIslands++;
                }
            }
        }

        return numIslands;
    }

    public void DFS(int row, int col)
    {
        // Check if Islands extends left.
        if(0 <= row - 1 && grid[row - 1][col] == '1')
        {
            grid[row - 1][col] = '0';
            DFS(row - 1, col);
        }
        // Check if Islands extends right.
        if(row + 1 < grid.Length && grid[row + 1][col] == '1')
        {
            grid[row + 1][col] = '0';
            DFS(row + 1, col);
        }
        // Check if Islands extends above.
        if(0 <= col - 1 && grid[row][col - 1] == '1')
        {
            grid[row][col - 1] = '0';
            DFS(row, col - 1);
        }
        // Check if Islands extends below.
        if(col + 1 < grid[0].Length && grid[row][col + 1] == '1')
        {
            grid[row][col + 1] = '0';
            DFS(row, col + 1);
        }
    }
}
