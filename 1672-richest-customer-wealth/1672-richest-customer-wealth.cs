
public class Solution {
    public int MaximumWealth(int[][] accounts) {
        SortedSet<int> customers = new SortedSet<int>();
        for (int m = 0; m < accounts.Length; m++) {
            int wealth = 0;
            for (int n = 0; n < accounts[m].Length; n++) {
                wealth += accounts[m][n];
            }

            customers.Add(wealth);
        }

        return customers.ElementAt(^1);
    }
}