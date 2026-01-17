public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word.Length == 0 || word.Length == 1) return true;

        char firstLetter = word[0];
        char secondLetter = word[1];
        for (int i = 1; i < word.Length; i++) {
            if (!Char.IsUpper(firstLetter) && Char.IsUpper(word[i])) {
                return false;
            }
            else if (Char.IsUpper(firstLetter) && Char.IsUpper(secondLetter)) {
                if (!Char.IsUpper(word[i])) {
                    return false;
                }
            }
            else if (Char.IsUpper(firstLetter) && !Char.IsUpper(secondLetter)) {
                if (Char.IsUpper(word[i])) {
                    return false;
                }
            }
        }

        return true;
    }
}