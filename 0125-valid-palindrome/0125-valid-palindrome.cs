public class Solution {
    public bool IsPalindrome(string s) {
        char[] charsToRemove = new char[] {' ', ',', ':', '"', '*', '-', '+', '.', ';', '/', '[', ']', '!',
                                            '!', '@', '#', '$', '%', '^', '&', '(', ')', '=', '_', '?', '{',
                                            '}', '\'', '\\', '`', '~'};
        s = s.ToLower();
        foreach(var c in charsToRemove) {
            s = s.Replace(c.ToString(), "");
        }

        int left = 0;
        int right = s.Length - 1;
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}