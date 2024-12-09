public class Solution {
    public int[] RunningSum(int[] nums) {
        int n = nums.Length;
        int[] prefixSum = new int[n];
        
        prefixSum[0] = nums[0];
        for (int i = 1; i < n; i++)
        {
            int addSum = prefixSum[i - 1] + nums[i];
            prefixSum[i] = addSum;
        }
        
        return prefixSum;
    }
}