public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] sneakyNumbers = new int[2];
        int pos = 0;
        foreach(var num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
                if (dict[num] > 1) {
                    sneakyNumbers[pos] = num;
                    pos++;
                    if (pos > 1) break;
                }

                continue;
            }

            dict[num] = 1;
        }

        return sneakyNumbers;
    }
}