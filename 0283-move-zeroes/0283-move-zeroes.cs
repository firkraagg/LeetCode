public class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums.Length == 1) return;
        int right = 1;
        int left = 0;
        while (right < nums.Length) {
            if (nums[right] != 0 && nums[left] == 0) {
                nums[left] = nums[right];
                nums[right] = 0;
                right++;
                left++;
            }
            else if (nums[left] != 0 && left < right) {
                left++;
            }
            else {
                right++;
            }
        }
    }
}