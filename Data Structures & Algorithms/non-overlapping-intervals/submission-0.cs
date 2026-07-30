public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a,b)=>a[0].CompareTo(b[0]));
        int result = 0;
        int prevEnd = intervals[0][1];
        for(int i=1; i<intervals.Length; i++){
            if (intervals[i][0] >= prevEnd){
                prevEnd = intervals[i][1];
            }
            else{
                result +=1;
                prevEnd = Math.Min(prevEnd, intervals[i][1]);
            }
        }
        return result;
    }
}
