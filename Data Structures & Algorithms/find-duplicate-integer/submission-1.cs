/*
_How does Floyd's Algorithm works?_
The algorithm is to start two pointers, slow and fast from head of linked list. We move slow one node at a time and fast two nodes at a time. If there is a loop, then they will definitely meet.
*/

public class Solution 
{
    public int FindDuplicate(int[] nums) 
    {
        int slow = 0;
        int fast = 0;

        while(slow < nums.Length)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];    //  If dupe is encountered, return to first occurrence.

            if(fast == slow)
            {
                slow = 0;
                break;
            }
        }

        while(slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }

        return fast;
    }
}
