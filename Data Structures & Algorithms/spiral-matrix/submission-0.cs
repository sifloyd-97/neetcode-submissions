public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        List<int> result = new List<int>();
        int row = matrix.Length;
        int col = matrix[0].Length;
        int top = 0, left = 0;
        int bottom = row-1, right = col-1;

        while (top<=bottom && left<=right)
        {
            for(int i=left; i<=right; i++){
                result.Add(matrix[top][i]);
            }
            top++;
            for(int i=top; i<=bottom; i++){
                result.Add(matrix[i][right]);
            }
            right--;
            if(top<=bottom){
                for(int i=right; i>=left; i--){
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
            }
            if(left<=right){
                for(int i=bottom; i>=top; i--){
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return result;        
    }
}
