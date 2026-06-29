public class Solution 
{
    public bool IsHappy(int n) 
    {
        HashSet<int> prevNums = new HashSet<int>();
        
        while(true)
        {
            int i = 0;
            while(n != 0)
            {
                i += (int) Math.Pow(n % 10, 2);
                n -= (n % 10);
                n /= 10;
            }

            if(i == 1)
                return true;
            else if(prevNums.Contains(i))
                return false;
            else
            {
                prevNums.Add(i);
                n = i;
            }
        }
    }
}
