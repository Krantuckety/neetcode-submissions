public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        digits[digits.Length - 1] = digits[digits.Length - 1] + 1;

        for(int i = digits.Length - 1; 0 <= i; i--)
        {
            if(digits[i] >= 10)
            {
                if(i == 0)
                {
                    digits = new int[digits.Length + 1];
                    digits[0] = 1;
                    return digits;
                }
                digits[i] = 0;
                digits[i-1] = digits[i-1] + 1;
            }
        }

        return digits;
    }
}
