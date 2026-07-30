public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int result = 0;

        foreach(int num in nums){
            if(!set.Contains(num-1)){
                int length = 1;
                while(set.Contains(num+length)) length++;
                result = Math.Max(result, length);
            }
        }
        return result;         
    }
}
