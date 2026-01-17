public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> row = new List<int>();
        long c = 1;
        for (int k = 0; k <= rowIndex; k++) {
            row.Add((int)c);
            c = c * (rowIndex - k) / (k + 1);
        }

        return row;
    }
}