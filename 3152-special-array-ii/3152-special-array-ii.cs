public class Solution {
    public bool[] IsArraySpecial(int[] nums, int[][] queries) {
        int n = nums.Length; // Lay do dai cua mang
        int[] prefix = new int[n];
        int m = queries.Length;
        bool[] result = new bool[m];

        // tao prefix
        for (int i = 1; i < n; i++)
        {
            prefix[i] = prefix[i - 1];
            if ((nums[i] % 2 == 0 && nums[i - 1] % 2 == 0) ||
                (nums[i] % 2 != 0 && nums[i - 1] % 2 != 0))
                {
                    prefix[i]++;
                }
        }

        for (int i = 0; i < m; i++)
        {
            int left = queries[i][0];
            int right = queries[i][1];

            int specialCount = prefix[right] - (left > 0 ? prefix[left] : 0);

            result[i] = (specialCount == 0);
        }

        return result;
    }
}