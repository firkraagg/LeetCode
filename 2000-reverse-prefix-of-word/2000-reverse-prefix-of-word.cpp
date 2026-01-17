class Solution {
public:
    string reversePrefix(string word, char ch) {
        size_t pos = word.find(ch);
        if (pos == string::npos) {
            return word;
        }
        int number = 0;
        for (int i = 0; i < word.size() - 1; i++) {
            if (word.at(i) == ch) {
                break;
            }
            ++number;
        }
        string str = word.substr(0, number + 1);
        reverse(str.begin(), str.end());
        word.replace(0, str.size(), str);
        return word;

    }
};