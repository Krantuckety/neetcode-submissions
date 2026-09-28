public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new();

        foreach (string block in path.Split('/')) {
            // A single period '.' represent the current directory.
            if(block == "" || block == ".")
                continue;
            
            // A double period '..' represents the previous/parent directory.
            if(block == "..") {      
                if(stack.Count > 0) {
                    stack.Pop();
                }
            } 
            else
                stack.Push(block);
        }

        string output = "/" + string.Join("/", stack.Reverse());
        return output;
    }
}