public class Solution {
    public string AddStrings(string num1, string num2) {
        string str = "";
        int maxLength = num1.Length >= num2.Length ? num1.Length : num2.Length;
        int remainder = 0;
        for (int i = 1; i <= maxLength; i++) {
            int firstNum = 0;
            int secondNum = 0;
            if (num1.Length >= i) {
                firstNum = (int)char.GetNumericValue(num1[num1.Length - i]);
            }
            if (num2.Length >= i) {
                secondNum = (int)char.GetNumericValue(num2[num2.Length - i]);
            }

            var tmpNum = firstNum + secondNum + remainder;
            remainder = 0;
            if (tmpNum > 9) {
                tmpNum %= 10;
                remainder++;
            }
            str = str.Insert(0, tmpNum.ToString());
        }

        if (remainder > 0) str = str.Insert(0, "1");
        return str;
    }
}