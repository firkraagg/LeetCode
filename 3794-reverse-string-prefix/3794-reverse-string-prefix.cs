public class Solution {
    public string ReversePrefix(string s, int k) {
        char[] str = s.ToCharArray();
        int left = 0;
        int right = k - 1;
        while (left < right) {
            char tmp = str[left];
            str[left] = str[right];
            str[right] = tmp;
            left++;
            right--;
        }

        return new string(str);
    }
}