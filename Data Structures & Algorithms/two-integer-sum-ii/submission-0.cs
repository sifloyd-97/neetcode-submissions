public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=0, r=numbers.Length-1;
        int[] res = new int[2];
        while(l<r){
            if(numbers[l]+numbers[r]>target){
                r--;
            }
            else if(numbers[l]+numbers[r]<target){
                l++;
            }
            else{
                res[0]=l+1;
                res[1]=r+1;
                break;
            }
        }
        return res;
    }
}
