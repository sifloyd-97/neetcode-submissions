public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        for (int i=0; i<n-1;i++)
        {
            for (int j=i+1; j<n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j]=matrix[j][i];
                matrix[j][i]=temp;
            }
        }
        Reverse(n, matrix);        
    }

    private void Reverse(int length, int[][] matrix)
    {
        for( int i =0; i<length; i++)
        {
            int start = 0;
            int end = length-1;

            while (start <= end)
            {
                int temp = matrix[i][start];
                matrix[i][start] = matrix[i][end];
                matrix[i][end] = temp;
                start++;
                end--;
            }
        }
    }



}
