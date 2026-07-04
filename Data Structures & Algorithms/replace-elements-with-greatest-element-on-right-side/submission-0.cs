public class Solution 
{
    public int[] ReplaceElements(int[] arr) 
    {
        int greatestSeen = arr[arr.Length - 1];
        int[] output = new int[arr.Length];
        for(int i = arr.Length - 2; 0 <= i; i--)
        {
            if(arr[i+1] > greatestSeen)
                greatestSeen = arr[i+1];
            output[i] = greatestSeen;
        }

        output[output.Length - 1] = -1;
        return output;
    }
}