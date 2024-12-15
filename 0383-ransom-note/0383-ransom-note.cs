public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var list = new List<char>(ransomNote);
        int res = 0;
        
        foreach (char element in magazine) // lap qua tat ca ky tu trong magazine
        {
            if (list.Remove(element)) // neu co ky tu de xoa thi res +1
            {
                res++;
            }
        }
        
        return ransomNote.Length == res;
    }
}