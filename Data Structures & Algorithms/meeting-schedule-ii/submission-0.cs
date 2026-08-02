/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        int room = 1;
        if (intervals.Count == 0){
            return 0;
        }
        else{
            intervals.Sort((a,b)=>a.start.CompareTo(b.start));
            for (int i =1;i<intervals.Count; i++){
                int prev_end = intervals[i-1].end;
                int curr_start = intervals[i].start;

                if (prev_end>curr_start){
                    room +=1;
                }
            }
        }
        return room;
    }
}
