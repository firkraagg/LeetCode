public class Solution {
    public int TotalMoney(int n) {
        int totalAmount = 0;
        int startFrom = 1;
        int amount = startFrom;
        for (int i = 1; i <= n; i++)
        {
            totalAmount += amount++;
            if (i % 7 == 0) amount = ++startFrom;
        }

        return totalAmount;
    }
}