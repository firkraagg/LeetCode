public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int> numbers = new();
        int index = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                numbers.Add(nums[i]);
                index++;
            }
        }

        for (int i = 0; i < numbers.Count(); i++) {
            nums[i] = numbers[i];
        }

        return numbers.Count();
    }
}