public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            switch(c)
            {
                case ')':
                    if((stack.Count > 0) && stack.Peek() == '(')
                    {
                        stack.Pop();
                    } 
                    else
                        return false;
                    break;
                case ']':
                    if((stack.Count > 0) &&stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                        return false;
                    break;
                case '}':
                    if((stack.Count > 0) &&stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                        return false;
                    break;
                default:
                    stack.Push(c);
                    break;
            }
        }
        if(stack.Count != 0)
            return false;
        return true;
    }
}
