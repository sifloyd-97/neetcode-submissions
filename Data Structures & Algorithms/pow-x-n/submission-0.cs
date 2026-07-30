public class Solution {
    public double MyPow(double x, int n) {
        double result = 1;
        long power = n;
        if (n<0){
            power = power*-1;
        }

        while(power>0){
            if(power%2==0){
                x=x*x;
                power = power / 2;
            }
            else{
                result = result * x;
                power = power-1;
            }
        }
        if(n<0){
            result = 1/result;
        }

        return result;
    }
}
