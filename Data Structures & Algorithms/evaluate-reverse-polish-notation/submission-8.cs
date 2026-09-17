public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        Stack<string> stack = new Stack<string>();
        string[] validOps = {"+", "-", "*", "/"};
        int result = int.Parse(tokens[0]);

        for(int i = 0; i < tokens.Length; i++)
        {
            if(validOps.Contains(tokens[i]))
            {
                result = performOperation(int.Parse(stack.Pop()), int.Parse(stack.Pop()), tokens[i]);
                stack.Push(result.ToString());
            }
            else
            {
                stack.Push(tokens[i]);
            }
        }
        return result;
    }

    public int performOperation(int num1, int num2, string op)
    {
        switch(op)
        {
            case "+":
                return (num2 + num1);
            case "-":
                return (num2 - num1);
            case "*":
                return (num2 * num1);
            case "/":
                return (num2 / num1);
            default: 
                return 0;
        }
    }
}
