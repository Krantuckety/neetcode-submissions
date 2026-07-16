public class Solution 
{
    public List<int> SpiralOrder(int[][] matrix) 
    {
        List<int> result = new();
        // Left-Right && Top-Bottom bounds.
        int l = 0, t = 0, r = matrix[l].Length - 1, b = matrix.Length - 1;
        while(l <= r && t <= b)
        {
            for(int i = l; i <= r; i++)
            {
                result.Add(matrix[t][i]);
            }
            t++;
            for(int i = t; i <= b; i++)
            {
                result.Add(matrix[i][r]);
            }
            r--;
            if(t > b || l > r)
                break;
            for(int i = r; l <= i; i--)
            {
                result.Add(matrix[b][i]);
            }
            b--;
            for(int i = b; t <= i; i--)
            {
                result.Add(matrix[i][l]);
            }
            l++;
        }
        
        return result;
    }
}
