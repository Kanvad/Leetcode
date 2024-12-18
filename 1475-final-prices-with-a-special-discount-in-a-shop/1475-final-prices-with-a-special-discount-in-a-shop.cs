public class Solution {
    public int[] FinalPrices(int[] prices) {
        int n = prices.Length;
        var result = prices; // sao chep mang

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (prices[j] <= prices[i])
                {
                    // neu co phan tu be hon o phia sau
                    result[i] = prices[i] - prices[j];
                    break;
                }
            }
        }

        return result;
    }
}