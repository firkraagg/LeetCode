
public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;
        for (int m = 0; m < accounts.Length; m++) {
            int wealth = 0;
            for (int n = 0; n < accounts[m].Length; n++) {
                wealth += accounts[m][n];
            }

            maxWealth = wealth > maxWealth ? wealth : maxWealth;
        }

        return maxWealth;
    }
}