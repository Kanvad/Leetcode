public class Solution {
    public int RomanToInt(string s) {
        // Dictionary<char, int> dictionary = new Dictionary<char, int>()
        //     {
        //         {'I',1 }, {'V',5}, {'X',10}, {'L',50}, {'C',100},
        //         {'D', 500}, {'M',1000}
        //     };
        
        int sum = 0;
        int last = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            // int current = dictionary[s[i]];
            int current = GetRomanValue(s[i]);
            if ( current < last)
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }

            last = current;
        }
        
        return sum;
    }
    
    private int GetRomanValue(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}