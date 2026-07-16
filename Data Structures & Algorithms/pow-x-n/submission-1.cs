public class Solution 
{
    public double MyPow(double x, int n) 
    {
        double mult = x;
        if(n >= 1)
        {
            for(int i = 1; i < n; i++)
            {
                x *= mult;
            }
        }
        else if(n < 0)
        {
            for(int i = 0; n <= i; i--)
            {
                x /= mult;
            }
        }
        else
        {
            return 1;
        }

        return x;
    }
}
