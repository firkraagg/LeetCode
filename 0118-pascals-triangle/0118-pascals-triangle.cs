public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();
        for (int i = 1; i <= numRows; i++) {
            IList<int> row = new List<int>();
            for (int j = 0; j < i; j++) {
                if (j == 0 || j + 1 == i) {
                    row.Add(1);
                    continue;
                } 

                int num = triangle[i - 2][j - 1] + triangle[i - 2][j];
                row.Add(num);
            }

            triangle.Add(row);
        }

        return triangle;
    }
}