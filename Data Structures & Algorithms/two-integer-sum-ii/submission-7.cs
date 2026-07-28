public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int[] output = new int[2];

        int fp = 0, bp = numbers.Length - 1;

        while(numbers[fp] + numbers[bp] != target)
        {
            if(numbers[fp] + numbers[bp] > target)
                bp--;
            else
                fp++;
        }
        output[0] = fp + 1;
        output[1] = bp + 1;
        if(output[0] > output[1])
        {
            int temp = output[0];
            output[0] = output[1];
            output[1] = temp;
        }

        return output;
    }
}
