public class Solution 
{
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        int left = 0;
        int right = matrix.Length - 1;
        int m = 0;
        while(left <= right)
        {
            m = (left + right) / 2;
            if(matrix[m][0] <= target)
            {
                if(target <= matrix[m][matrix[m].Length - 1])
                    break;
                else
                {
                    left = m + 1;
                }
            }
            else
            {
                right = m - 1;
            }
        }

        left = 0;
        right = matrix[m].Length - 1;
        int n = 0;

        while(left <= right)
        {
            n = (left + right) / 2;
            if(matrix[m][n] == target)
            {
                return true;
            }
            else if(matrix[m][n] < target)
            {
                left = n + 1;
            }
            else
            {
                right = n - 1;
            }
        }

        return false;
    }
}
