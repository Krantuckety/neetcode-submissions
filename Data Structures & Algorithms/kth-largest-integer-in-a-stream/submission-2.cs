public class KthLargest 
{
    PriorityQueue<int, int> pq = new();
    int k;

    public KthLargest(int k, int[] nums) 
    {
        this.k = k;

        for(int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(nums[i], nums[i]);
            if(pq.Count > k)
                pq.Dequeue();
        }
    }
    
    public int Add(int val) 
    {
        pq.Enqueue(val, val);

        if(pq.Count > k)
            pq.Dequeue();

        return pq.Peek();
    }
}
