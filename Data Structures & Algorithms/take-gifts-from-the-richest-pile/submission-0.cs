public class Solution 
{
    public long PickGifts(int[] gifts, int k) 
    {
        PriorityQueue<int, int> pq = new();

        // Populate the priority queue.
        for(int i = 0; i < gifts.Length; i++)
        {
            pq.Enqueue(gifts[i], -gifts[i]);
        }

        int output = 0;
        // Remove gifts and add to output
        for(int i = 0; i < k; i++)
        {
            int num = (int) Math.Sqrt(pq.Dequeue());
            pq.Enqueue(num, -num);
        }

        // Add remaining numbers to output
        while(pq.Count != 0)
            output += pq.Dequeue();
        
        return output;
    }
}