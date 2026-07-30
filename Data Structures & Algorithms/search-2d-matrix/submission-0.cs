public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int ROW = matrix.Length, COLS = matrix[0].Length;
        int l=0, r=ROW*COLS - 1;

        while(l<=r){
            int mid = l+(r-l)/2;
            int row = mid/COLS, col = mid%COLS;
            if(target>matrix[row][col]) l=mid+1;
            else if(target<matrix[row][col]) r=mid-1;
            else return true;
        }
        return false;
    }
}
