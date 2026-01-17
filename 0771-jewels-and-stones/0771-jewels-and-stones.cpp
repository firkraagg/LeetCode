class Solution {
public:
    int numJewelsInStones(string jewels, string stones) {\
        int counter = 0;
        for(int i = 0; i < jewels.length(); i++) {
            char jewel = jewels.at(i);
            for(int j = 0; j < stones.length(); j++) {
                char stone = stones.at(j);
                if (jewel == stone) {
                    counter++;
                }
            }
        }
        return counter;
    }
};