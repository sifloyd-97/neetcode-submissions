public class Solution {
    public int MaxProfit(int[] prices) {
        int minprice = int.MaxValue;
        int maxprofit = 0;

        for(int i=0; i<prices.Length; i++){
            minprice = Math.Min(minprice, prices[i]);
            maxprofit = Math.Max(maxprofit, prices[i]-minprice);
        }

        return maxprofit;
    }
}
