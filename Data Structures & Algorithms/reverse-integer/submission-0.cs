public class Solution {
    public int Reverse(int x) {
        int max = int.MaxValue;
        int min = int.MinValue;
        int result =0;
        
        while (x!=0)
        {
            int dig = x%10;
            x = x/10;
            if ((result>(max/10) || (result==(max/10) && dig>(max%10)))){
                return 0;
            }
            else if ((result<(min/10) || (result==(min/10) && dig<(min%10))))
            {
                return 0;
            }
            result = result*10+dig;

        }
        return result;
    }
}
