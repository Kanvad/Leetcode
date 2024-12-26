public class Solution {
    public int[] PlusOne(int[] digits) {
        // string num1 = "";

        // foreach (var i in digits) {
        //     num1 += i.ToString();
        // }

        // num1 = (int.Parse(num1) + 1).ToString();

        // int[] res = new int[num1.Length];
        // foreach (string i in num1) {
        //     res.Add(int.Parse(i));
        // }

        // return res;
        // co the nhung khong toi uu

        int n = digits.Length;
        int carry = 1;
        
        for (int i = n - 1; i >= 0; i--) {
            int sum = digits[i] + carry;
            digits[i] = sum % 10;
            carry = sum / 10;
            if (carry == 0) {
                return digits;
            }
        }
        
        int[] result = new int[n + 1];
        result[0] = carry;
        for (int i = 0; i < n; i++) {
            result[i + 1] = digits[i];
        }
        
        return result;
    }
}