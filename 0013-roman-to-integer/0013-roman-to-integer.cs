public class Solution {
    public int RomanToInt(string s) {
        int number = 0;
        int i = s.Length - 1;
        while (i >= 0) {
            var romanNumber = s[i];
            switch(romanNumber) {
                case 'I':
                    number += 1;
                    break;
                case 'V':
                    if ((i != 0) && (s[i-1] == 'I')) {
                        number += 4;
                        i--;
                        break;
                    }

                    number += 5;
                    break;
                case 'X':
                    if ((i != 0) && (s[i-1] == 'I')) {
                        number += 9;
                        i--;
                        break;
                    }

                    number += 10;
                    break;
                case 'L':
                    if ((i != 0) && (s[i-1] == 'X')) {
                        number += 40;
                        i--;
                        break;
                    }

                    number += 50;
                    break;
                case 'C':
                    if ((i != 0) && (s[i-1] == 'X')) {
                        number += 90;
                        i--;
                        break;
                    }

                    number += 100;
                    break;
                case 'D':
                    if ((i != 0) && (s[i-1] == 'C')) {
                        number += 400;
                        i--;
                        break;
                    }

                    number += 500;
                    break;
                case 'M':
                    if ((i != 0) && (s[i-1] == 'C')) {
                        number += 900;
                        i--;
                        break;
                    }

                    number += 1000;
                    break;
            }

            i--;
        }

        return number;
    }
}