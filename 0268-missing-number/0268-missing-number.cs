public class Solution {
    public int MissingNumber(int[] nums) {
        int numsSum = 0;
        int expectedSum = 0;
        for (int i = 0; i < nums.Length; i++) {
            numsSum += nums[i];
            expectedSum += i;
            if (i == nums.Length - 1 && numsSum != expectedSum) {
                expectedSum += i + 1;
                if (expectedSum == numsSum) {
                    return 0;
                }
            } 
        }

        return numsSum == expectedSum ? nums.Max() + 1 : expectedSum - numsSum;
    }
}