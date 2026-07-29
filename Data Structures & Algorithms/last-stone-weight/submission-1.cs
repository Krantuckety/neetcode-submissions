public class Solution 
{
    public int LastStoneWeight(int[] stones) 
    {
        PriorityQueue<int, int> pq = new();
        for(int i = 0; i < stones.Length; i++)
        {
            pq.Enqueue(stones[i], -stones[i]);
        }

        while(pq.Count != 1)
        {
            int s1 = pq.Dequeue(), s2 = pq.Dequeue();
            if(s1 >= s2)
            {
                s1 -= s2;
                pq.Enqueue(s1, -s1);
            }
            else
            {
                s2 -= s1;
                pq.Enqueue(s2, -s2);
            }
        }

        return pq.Dequeue();
    }
}
