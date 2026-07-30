public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalgas = 0;
        int totalcost = 0;
        int startindex = 0;
        int tank = 0;

        for(int i = 0;i<gas.Length; i++){
            totalgas += gas[i];
            totalcost += cost[i];
            tank += gas[i] - cost[i];
            
            if (tank<0){
                startindex = i+1;
                tank =0;
            }
        }
        if (totalcost>totalgas){
                return -1;
        }
        return startindex;
    }
}
