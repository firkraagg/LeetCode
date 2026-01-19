public class Solution {
    public int[] TransformArray(int[] nums) {
        int even = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] % 2 == 0) even++;
        }

        for (int i = 0; i < nums.Length; i++) {
            nums[i] = (i < even) ? 0 : 1;
        }

        return nums;
    }
}