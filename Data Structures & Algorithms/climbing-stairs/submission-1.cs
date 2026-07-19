public class Solution 
{
    public int ClimbStairs(int n) 
    {     
        int currentHighest = 1;

        if( n <= 2)
            return n;
        
        int a = 2;
        int b = 1;

        for(int i = 3; i <= n; i++)
        {
            int curr = a + b;
            b = a;
            a = curr;
        }

        return a;
    }
}
