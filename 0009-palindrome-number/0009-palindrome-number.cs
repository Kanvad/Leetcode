public class Solution {
    public bool IsPalindrome(int x) {
                
        if (x < 0) // neu < 0
            return false;
        
        string num1 = x.ToString();
        string num2 = "";
        
        if (num1[0] != num1[num1.Length - 1])
            return false;
        
        for (int i = num1.Length - 1; i >= 0; i--)
        {
            num2 += num1[i];
        }
        int temp = int.Parse(num2);

        if (x == temp)
            return true;
        
        return false;
    }
}