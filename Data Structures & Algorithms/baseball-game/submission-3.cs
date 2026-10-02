public class Solution 
{
    public int CalPoints(string[] operations) 
    {
        Stack<int> stack = new();
        foreach(string str in operations)
        {
            int temp = 0;
            if(str.Contains("+"))
                temp = stack.ToArray()[0] + stack.ToArray()[1];
            else if(str.Contains("D"))
                temp = (2 * stack.Peek());
            else if(str.Contains("C"))
            {
                stack.Pop();
                continue;
            }
            else
                temp = int.Parse(str);
            
            stack.Push(temp);
        }

        int points = 0;
        while(stack.Count != 0)
            points += stack.Pop();

        return points;
    }
}