public class Solution {
    public int AddDigits(int num) {
        int number = num;
        while (number > 9) {
            string str = number.ToString();
            int tmpNum = 0;
            for (int i = 0; i < str.Length; i++) {
                tmpNum += int.Parse(str[i].ToString());
            }

            number = tmpNum;
        }

        return number;
    }
}