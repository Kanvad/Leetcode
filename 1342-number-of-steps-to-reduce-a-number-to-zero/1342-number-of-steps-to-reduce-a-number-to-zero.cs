public class Solution {
    public int NumberOfSteps(int num) {
        int step = 0;
        
        // dem cac buoc thuc hien
        while (num > 0)
        {
            if (num % 2 == 0) num /=2;
            else num--;
            
            step++;
        }
        
        return step;
    }
}