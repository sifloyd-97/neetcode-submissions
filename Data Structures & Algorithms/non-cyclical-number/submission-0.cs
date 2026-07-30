public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seen = new HashSet<int>();

        while(n!=1 && !seen.Contains(n) ){
            seen.Add(n);
            n = getSquare(n);
        }
        return n==1;
    }

    private int getSquare(int n){
        int sum = 0;
        while (n>0){
            int digit = n%10;
            sum += digit*digit;
            n = n/10;
        }
        return sum;
    }
}
