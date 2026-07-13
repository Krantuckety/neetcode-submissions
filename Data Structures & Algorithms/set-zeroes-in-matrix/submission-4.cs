public class Solution 
{
    public void SetZeroes(int[][] matrix) 
    {
        HashSet<int> zeroRows = new HashSet<int>();
        HashSet<int> zeroCols = new HashSet<int>();

        for(int x = 0; x < matrix.Length; x++)
        {
            for(int y = 0; y < matrix[x].Length; y++)
            {
                if(matrix[x][y] == 0)
                {
                    zeroRows.Add(y);
                    zeroCols.Add(x);
                }
            }
        }

        // Set the determined cols to 0
        foreach(int num in zeroCols)
        {
            matrix[num] = new int[matrix[num].Length];
        }

        // Set the determined rows to 0
        foreach(int num in zeroRows)
        {
            for(int y = 0; y < matrix.Length; y++)
            {
                matrix[y][num] = 0;
            }
        }
    }
}
