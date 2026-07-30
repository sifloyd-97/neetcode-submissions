public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b)=>a[0].CompareTo(b[0]));
        List<int[]> result = new List<int[]>();
        for(int i=0; i<intervals.Length; i++){
            if(result.Count == 0 || intervals[i][0] > result.LastOrDefault()[1]){
                result.Add(intervals[i]);
            }
            else{
                result.LastOrDefault()[1] = Math.Max(result.LastOrDefault()[1], 
                intervals[i][1]);
            }
        }
        return result.ToArray();
    }
}
