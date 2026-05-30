public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        int finalArea = 0;
        int b1 = 0;
        int b2 = heights.Length - 1;
        for(int i = 0; i < heights.Length; i++)
        {
            int area = Math.Min(heights[b1], heights[b2]) * (b2 - b1);
            if(area > finalArea)
                finalArea = area;
            if(heights[b1] > heights[b2])
                b2--;
            else
                b1++;
        }
        return finalArea;
    }
}
