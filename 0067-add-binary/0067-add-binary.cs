public class Solution {
    public string AddBinary(string a, string b) {
        // dung StringBuilder de tao bien
        StringBuilder result = new StringBuilder();
        int i = a.Length - 1;
        int j = b.Length - 1;
        // tao gia tri nho
        int carry = 0;

        while (i >= 0 || j >= 0)
        {
            int sum = carry;
            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';
            // lay 0 cua 10
            result.Insert(0, (sum % 2).ToString());
            // lay 1
            carry = sum / 2;
        }

        // neu van con gia tri nho thi them no vao dau chuoi
        if (carry != 0)
            result.Insert(0, carry.ToString());

        return result.ToString();
    }
}