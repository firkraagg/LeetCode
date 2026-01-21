public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] sneakyNumbers = new int[2];
        int pos = 0;
        foreach(var num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
                continue;
            }

            dict[num] = 1;
        }

        foreach(var kvp in dict) {
            if (kvp.Value > 1) {
                sneakyNumbers[pos] = kvp.Key;
                pos++;
            }
        }

        return sneakyNumbers;
    }
}