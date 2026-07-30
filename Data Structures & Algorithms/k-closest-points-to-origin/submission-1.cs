public class Solution 
{
    public int[][] KClosest(int[][] points, int k) 
    {
        PriorityQueue<int[], double> pq = new();

        for(int i = 0; i < points.Length; i++)
        {
            double dist = Math.Sqrt(Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2));
            pq.Enqueue(points[i], dist);
        }
        // Output creation block.
        int j = 0;
        int[][] output = new int[k][];
        while(j < k)
        {
            int[] dq = pq.Dequeue();
            output[j] = new int[2];
            output[j][0] = dq[0];
            output[j][1] = dq[1];
            j++;
        }
        return output;
    }
}
