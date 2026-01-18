public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        List<int> numsList = nums.ToList();
        for (int i = 0; i < nums.Length; i++) {
            int element = numsList.ElementAt(i);
            if (element % 2 == 0) {
                numsList.RemoveAt(i);
                numsList.Insert(0, element);
            }
        }

        return numsList.ToArray();
    }
}