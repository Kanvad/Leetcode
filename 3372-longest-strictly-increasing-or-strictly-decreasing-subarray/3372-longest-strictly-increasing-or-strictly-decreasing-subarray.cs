public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        if (nums.Length == 0) return 0;

        int res = 1;
        int res1 = 1;
        int maxLength = 1;

        // strictly increasing
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] < nums[i+1]) {
                res++;
            }
            else {
                res = 1;
            }
            maxLength = Math.Max(maxLength, res);
        }

        // strictly decreasing
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] > nums[i+1]) {
                res1++;
            }
            else {
                res1 = 1;
            }
            maxLength = Math.Max(maxLength, res1);
        }

        // return res > res1 ? res : res1;
        return maxLength;
    }
}