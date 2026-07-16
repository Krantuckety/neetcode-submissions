public class MedianFinder 
{
    // First int is val, Second int is priority.
    PriorityQueue<int, int> minHeap;    // Stores top half of Nums.
    PriorityQueue<int, int> maxHeap;    // Stores bottom half of Nums.

    public MedianFinder() 
    {
        minHeap = new PriorityQueue<int, int>();
        maxHeap = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) 
    {
        if(minHeap.Count != 0 && num > minHeap.Peek())
        {
            minHeap.Enqueue(num, num);
        }
        else
        {
            maxHeap.Enqueue(num, (num * -1));
        }

        // Check if heaps are inbalanced (Size difference greater than 1).
        if(minHeap.Count > maxHeap.Count + 1)
        {
            int n = minHeap.Dequeue();
            maxHeap.Enqueue(n, (n * -1));
        }
        else if(maxHeap.Count > minHeap.Count + 1)
        {
            int n = maxHeap.Dequeue();
            minHeap.Enqueue(n, n);
        }
    }
    
    public double FindMedian() 
    {
        if(minHeap.Count == maxHeap.Count)
        {
            return ((minHeap.Peek() + maxHeap.Peek()) / 2.0);
        }
        else if(minHeap.Count > maxHeap.Count)
        {
            return ((double) minHeap.Peek());
        }
        else
        {
            return ((double) maxHeap.Peek());
        }
    }
}
