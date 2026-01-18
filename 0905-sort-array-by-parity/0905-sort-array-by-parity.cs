public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        while (left < right) {
            if (nums[right] % 2 != 0) {
                right--; 
                continue; 
            } 

            if (nums[left] % 2 == 0) {
                left++;
                continue;
            }

            int tmp = nums[left];
            nums[left] = nums[right];
            nums[right] = tmp;

            left++;
            right--;
        }

        return nums;
    }
}