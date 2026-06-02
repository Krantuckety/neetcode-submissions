public class Solution 
{
    public int LargestRectangleArea(int[] heights) 
    {
        int maxArea = 0;
        Stack<(int index, int height)> stack = new Stack<(int, int)>();

        for(int i = 0; i < heights.Length; i++)
        {
            int rectStart = i;

            while(stack.Count != 0 && heights[i] < stack.Peek().height)
            {
                var (index, height) = stack.Pop();

                int rectArea = height * (i - index);
                maxArea = Math.Max(rectArea, maxArea);

                rectStart = index;
            }

            stack.Push((rectStart, heights[i]));
        }

        while (stack.Count != 0)
        {
            var (index, height) = stack.Pop();

                int rectArea = height * (heights.Length - index);
                maxArea = Math.Max(rectArea, maxArea);
        }

        return maxArea;
    }
}
