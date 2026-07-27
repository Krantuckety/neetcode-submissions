public class Solution 
{
    Queue<(int row, int col)> queue = new();

    public int OrangesRotting(int[][] grid) 
    {
        int fresh = 0;
        for(int m = 0; m < grid.Length; m++)
        {
            for(int n = 0; n < grid[m].Length; n++)
            {
                if(grid[m][n] == 2)
                {
                    queue.Enqueue((m, n));
                }
                if(grid[m][n] == 1)
                {
                    fresh++;
                }
            }
        }

        return BFS(grid, fresh);
    }

    private int BFS(int[][] grid, int fresh)
    {
        int mins = 0;

        while(queue.Count != 0)
        {   
            int size = queue.Count;

            for(int i = 0; i < size; i++)
            {
                var (m, n) = queue.Dequeue();

                // Check above
                if(0 < m && m < grid.Length && grid[m-1][n] == 1)
                {
                    grid[m-1][n] = 2;
                    fresh--;
                    queue.Enqueue((m-1, n));
                }

                // Check below
                if(m < grid.Length - 1 && grid[m+1][n] == 1)
                {
                    grid[m+1][n] = 2;
                    fresh--;
                    queue.Enqueue((m+1, n));
                }

                // Check left
                if(0 < n && n < grid[m].Length && grid[m][n-1] == 1)
                {
                    grid[m][n-1] = 2;
                    fresh--;
                    queue.Enqueue((m, n-1));
                }

                // Check right
                if(n < grid[m].Length - 1 && grid[m][n+1] == 1)
                {
                    grid[m][n+1] = 2;
                    fresh--;
                    queue.Enqueue((m, n+1));
                }
            }
            if(queue.Count != 0)
            {
                mins++;
            }
        }

        if(fresh != 0)
        {
            return -1;
        }

        return mins;
    }
}
