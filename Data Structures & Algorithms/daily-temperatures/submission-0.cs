public class Solution 
{
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int[] output = new int[temperatures.Length];
        Stack<(int index, int temp)> stack = new Stack<(int, int)>();

        for(int i = 0; i < temperatures.Length - 1; i++)
        {
            stack.Push((i, temperatures[i]));
            while(stack.Count != 0 && stack.Peek().temp < temperatures[i+1])
            {
                output[stack.Peek().index] = i + 1 - stack.Peek().index;
                stack.Pop();
            }
        }

        output[temperatures.Length - 1] = 0;
        return output;
    }
}
