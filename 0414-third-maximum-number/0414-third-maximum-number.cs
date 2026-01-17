public class Solution {
    public int ThirdMax(int[] nums) {
        SortedSet<int> sortedNums = new();
        foreach (var num in nums) {
            sortedNums.Add(num);
        }

        return sortedNums.Count > 2 ? sortedNums.ElementAt(sortedNums.Count - 3) : sortedNums.ElementAt(^1);
    }
}