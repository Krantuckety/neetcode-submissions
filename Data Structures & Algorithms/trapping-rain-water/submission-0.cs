public class Solution 
{
    public int Trap(int[] height) 
    {
        int[] maxLeft = new int[height.Length];
        int[] maxRight = new int[height.Length];

        for(int i = 0; i < height.Length; i++)
        {
            if(0 < i)
                maxLeft[i] = Math.Max(maxLeft[i-1], height[i-1]);
        }

        for(int i = height.Length - 1; 0 < i; i--)
        {
            if(i < height.Length - 1)
                maxRight[i] = Math.Max(maxRight[i+1], height[i+1]);
        }

        int output = 0;
        for(int i = 1; i < height.Length - 1; i++)
        {
            int n = Math.Min(maxLeft[i], maxRight[i]) - height[i];
            if(0 < n)
                output += n;
        }

        return output;
    }
}
