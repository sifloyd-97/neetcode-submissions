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
       int n = intervals.Count;
       int[] start_time = new int[n];
       int[] end_time = new int[n];

       for (int i=0;i<n;i++){
        start_time[i] = intervals[i].start;
        end_time[i] = intervals[i].end;
       }

       Array.Sort(start_time);
       Array.Sort(end_time);

       int room=0, count=0, s=0, e=0;

       while(s<n){
        if(start_time[s]<end_time[e]){
            s++;
            count++;
        }
        else{
            e++;
            count--;
        }
        room = Math.Max(room,count);
       }
       return room;
    }
}
