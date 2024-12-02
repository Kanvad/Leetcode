public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        // Variable declaration
        List<string> words_list = new List<string>();
        string current_word = "";
        int index = 0;

        // Add the currentWord to the words list
        for (int i = 0; i < sentence.Length; i++) {
            if (sentence[i] != ' ') {
                current_word += sentence[i];
            }
            else {
                words_list.Add(current_word);
                current_word = "";
            }
        }

        // Add the last word if there is no trailing space
        if (current_word.Length > 0) {
            words_list.Add(current_word);
        }

        // Find searchWord in words_list
        foreach (string word in words_list) {
            index++;
            if (word.StartsWith(searchWord)) {
                return index;
            }
        }

        return -1; // If no word starts with searchWord
    }
}