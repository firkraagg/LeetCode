public class Solution {
    public string ReverseOnlyLetters(string s) {
        int left = 0;
        int right = s.Length - 1;
        char[] charStr = s.ToCharArray();
        bool isNonEnglish = false;
        while (left < right) 
        {
            isNonEnglish = false;
            if (!char.IsLetter(charStr[left])) {
                left++;
                isNonEnglish = true;
            }
            if (!char.IsLetter(charStr[right])) {
                right--;
                isNonEnglish = true;
            }

            if (isNonEnglish) continue;
            char tmp = charStr[left];
            charStr[left] = charStr[right];
            charStr[right] = tmp;
            left++;
            right--;
        }

        return new string(charStr);
    }
}