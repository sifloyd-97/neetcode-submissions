public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numset = new HashSet<int>(nums);
        return numset.Count<nums.Length;
    }
}