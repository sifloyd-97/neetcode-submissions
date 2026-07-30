public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        for (int i = n-1; i>=0; i--){
            if (digits[i]<9){
                digits[i]+=1;
                return digits;
            }
            else{
                digits[i] = 0;
            }
        }
        int[] zeroArray = new int[n+1];
        zeroArray[0] = 1;
        return zeroArray;        
    }
}