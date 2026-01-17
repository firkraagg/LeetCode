public class Solution {
    public bool IsPalindrome(int x) {
        String number = x.ToString();
        int numberHalfLength = number.Length / 2;
        bool isPalindrome = true;
        for (int i = 1; i <= numberHalfLength; i++) {
            if (number[i - 1] != number[^i]) {
                isPalindrome = false;
            }
        }

        return isPalindrome;
    }
}