public class Solution {
    public string ReverseVowels(string s) {
        int left = 0;
        int right = s.Length - 1;
        char tmp;
        string vowels = "aeiouAEIOU";
        char[] c = s.ToCharArray();
        while (left < right) {
            if (vowels.Contains(c[left])) {
                if (vowels.Contains(c[right])) {
                    tmp = c[left];
                    c[left] = c[right];
                    c[right] = tmp;
                    left++;
                    right--;
                }
                else {
                    right--;
                }
            }
            else {
                left++;
            }
        }

        return new string(c);
    }
}