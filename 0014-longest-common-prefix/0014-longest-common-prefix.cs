public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        String lcp = "";
        var shortestWord = strs.MinBy(s => s.Length);
        int wordLength = shortestWord.Length;
        bool isTheSame = true;
        var word = strs[0];
        for (int i = 0; i < wordLength; i++) {
            var newChar = word[i];
            foreach(var str in strs) {
                if (str[i] != newChar) {
                    isTheSame = false;
                }
            }

            if (isTheSame) {
                lcp += newChar;
            }
        }
        
        return lcp;
    }
}