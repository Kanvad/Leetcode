public class Solution {
    public int MySqrt(int x) {
        if (x < 2) return x;

        int left = 1;
        int right = x;
        int res = 0;

        // tim kiem nhi phan
        while (left <= right) 
        {
            int mid = left + (right - left) / 2;
            if (mid <= (x / mid))
            {
                res = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return res;
    }
}