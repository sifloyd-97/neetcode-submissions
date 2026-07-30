public class Solution {
    public int MaxArea(int[] heights) {
        int l=0; 
        int r=heights.Length-1; 
        int result=0;
        while(l<r){
            int area=(r-l)*(Math.Min(heights[l], heights[r]));
            result = Math.Max(result, area);

            if(heights[l]<heights[r]){
                l++;
            }
            else{
                r--;
            }
        }
        return result;        
    }
}
