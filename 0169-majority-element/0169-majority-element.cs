public class Solution {
    public int MajorityElement(int[] nums) {
        IEnumerable<int> uniqueNums = nums.Distinct<int>();
        Hashtable ht = new Hashtable();
        foreach(var number in uniqueNums) {
            ht.Add(number, nums.Count(n => n == number));
        }

        int majorityElement = 1;
        int count = 0;
        foreach(DictionaryEntry de in ht) {
            int value = (int)de.Value; 
            if (value > count) {
                count = value;
                int key = (int)de.Key;
                majorityElement = key;
            }
        }

        return majorityElement;
    }
}