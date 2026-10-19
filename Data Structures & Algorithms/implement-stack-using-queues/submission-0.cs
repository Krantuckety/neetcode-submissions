public class MyStack 
{
    Queue<int> q;
    public MyStack() 
    {
        q = new();
    }
    
    public void Push(int x) 
    {
        q.Enqueue(x);
        for(int i = 0; i < q.Count - 1; i++)
            q.Enqueue(q.Dequeue());
    }
    
    public int Pop() 
    {
        if(Empty()) 
            throw new InvalidOperationException("Stack is empty");
        return q.Dequeue();
    }
    
    public int Top() 
    {
        if(Empty()) 
            throw new InvalidOperationException("Stack is empty");
        return q.Peek();
    }
    
    public bool Empty() {
        if(q.Count <= 0)
            return true;
        return false;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */