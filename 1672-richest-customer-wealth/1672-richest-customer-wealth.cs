public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = -1;
        
        foreach (int[] customer in accounts)
        {
            int total = 0;
            for (int i = 0; i < customer.Length; i++)
            {
                total += customer[i];
            }
            
            if (maxWealth < total) maxWealth = total;
        }
        
        return maxWealth;
    }
}