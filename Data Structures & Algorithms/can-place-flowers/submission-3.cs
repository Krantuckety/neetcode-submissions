public class Solution 
{
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        int numSpots = 0;
        int[] f = new int[flowerbed.Length + 2];
        for(int i = 0; i < flowerbed.Length; i++)
        {
            f[i+1] = flowerbed[i];
        }

        for(int i = 1; i <= flowerbed.Length; i++)
        {
            if(f[i] == 0 && f[i-1] == 0 && f[i+1] == 0)
            {
                numSpots++;
                f[i] = 1;
            }
        }

        if(numSpots >= n)
            return true;
        return false;
    }
}