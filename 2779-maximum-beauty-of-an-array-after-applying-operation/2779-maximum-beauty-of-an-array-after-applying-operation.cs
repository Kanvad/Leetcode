public class Solution {
    public int MaximumBeauty(int[] nums, int k) {
        Array.Sort(nums); // sap xep mang
        int maxBeauty = 0;
        
        // tao ham tim kiem
        int FindUpperBound(int[] arr, int val)
        {
            int low = 0, high = arr.Length - 1, result = 0;
            
            // tim kiem nhi phan
            while (low <= high) {
                int mid = low + (high - low) / 2;
                
                if (arr[mid] <= val) {
                    result = mid;
                    low = mid + 1;
                } else {
                    high = mid - 1;
                }
            }
            
            return result;
        }
        
        // goi ham
        for (int i = 0; i < nums.Length; i++)
        {
            int upperBound = FindUpperBound(nums, nums[i] + 2 * k);
            
            maxBeauty = Math.Max(maxBeauty, upperBound - i + 1);
        }
        
        return maxBeauty;
    }
}
// 2024/12/11