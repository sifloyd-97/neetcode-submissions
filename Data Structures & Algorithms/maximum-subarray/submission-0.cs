public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int curr = nums[0];

        for (int i = 1; i<nums.Length; i++){
            curr = Math.Max(curr + nums[i], nums[i]);
            maxSum = curr;
        }
        return maxSum;
    }
}
