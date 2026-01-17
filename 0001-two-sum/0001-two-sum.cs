public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] twoSum = new int[2];
        bool foundTwoSum = false;
        for (int i = 0; i < nums.Length; i++) {
            if (foundTwoSum) { break; }
            for (int j = i + 1; j < nums.Length; j++ ) {
                if ((nums[i] + nums[j]) == target) {
                    twoSum[0] = i;
                    twoSum[1] = j;
                    foundTwoSum = true;
                    break;
                }
            }
        }

        return twoSum;
    }
}