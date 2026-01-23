
public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;
        for (int m = 0; m < accounts.Length; m++) {
            int actWealth = 0;
            for (int n = 0; n < accounts[m].Length; n++) {
                actWealth += accounts[m][n];
            }

            maxWealth = actWealth > maxWealth ? actWealth : maxWealth;
        }

        return maxWealth;
    }
}