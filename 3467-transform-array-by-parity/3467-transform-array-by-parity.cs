public class Solution {
    public int[] TransformArray(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            nums[i] = nums[i] % 2 == 0 ? 0 : 1;
        }

        Array.Sort(nums);
        return nums;
    }
}