public class Solution 
{
    public int MinEatingSpeed(int[] piles, int h) 
    {
        // Find max
        Array.Sort(piles);
        int max = piles[piles.Length - 1];

        // Vars for a Binary Search
        int left = 1;
        int right = max;
        int mid = 1;
        int k = max;

        // Determine the worst case scenario for how long it takes to eat based on the largest value.
        while(left <= right)
        {
            mid = (left + right) / 2;
            int hrsEating = 0;
            for(int i = 0; i < piles.Length; i++)
            {
                hrsEating += (piles[i] / mid);
                if(piles[i] % mid != 0)
                    hrsEating++;
            }
            if(hrsEating > h)
                left = mid + 1;
            else
            {
                right = mid - 1;
                if(mid < k)
                    k = mid;
            }
        }

        return k;
    }
}
