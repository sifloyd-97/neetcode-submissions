public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int[]> stack = new Stack<int[]>();
        int[] result = new int[temperatures.Length];
        
        for(int i=0;i<temperatures.Length; i++){
            int temp = temperatures[i];
            while(stack.Count>0 && temp>stack.Peek()[0]){
                int[] pair = stack.Pop();
                result[pair[1]] = i - pair[1];
            }
            stack.Push(new int[]{temp,i});
        }
        return result;
    }
}
