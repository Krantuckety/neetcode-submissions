public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;
        for (int i = 0; i < n - 1; i++) {
            bool swapped = false;
            for (int j = 0; j < n - 1 - i; j++) {
                if (nums[j] > nums[j + 1]) {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
        return nums;
    }
}