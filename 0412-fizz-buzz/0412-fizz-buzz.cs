public class Solution {
    public IList<string> FizzBuzz(int n) {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= n; i++) {
            if (i % 3 == 0 && i % 5 == 0) sb.Append("FizzBuzz");
            else if (i % 3 == 0) sb.Append("Fizz");
            else if (i % 5 == 0) sb.Append("Buzz");
            else sb.Append(i);
            if (i < n) sb.Append(",");
        }
        return sb.ToString().Split(',');
    }
}