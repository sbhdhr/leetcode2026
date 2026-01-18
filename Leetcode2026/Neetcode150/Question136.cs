using System.Text;

namespace Leetcode2026.Neetcode150;

/*
48. Rotate Image
Medium
You are given an n x n 2D matrix representing an image,
rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to
modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.

Example 1:

Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [[7,4,1],[8,5,2],[9,6,3]]
Example 2:

Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]

Constraints:

n == matrix.length == matrix[i].length
1 <= n <= 20
-1000 <= matrix[i][j] <= 1000
*/

public static class Question136
{
    // Helper methods
    private static void Transpose(int[][] matrix)
    {
        int r = matrix.Length;

        for (int i = 0; i < r; i++)
        {
            for (int j = i + 1; j < r; j++)
            {
                //swap matrix[i][j] & matrix[j][i]
                (matrix[j][i], matrix[i][j]) = (matrix[i][j], matrix[j][i]);
            }
        }
    }

    //Solution method
    public static void Rotate(int[][] matrix)
    {
        //Transpose matrix then reverse the columns
        Transpose(matrix);
        for (int i = 0; i < matrix.Length; i++)
        {
            int l = 0;
            int r = matrix[i].Length - 1;
            while (l < r)
            {
                (matrix[i][l], matrix[i][r]) = (matrix[i][r], matrix[i][l]);
                l++;
                r--;
            }
        }

        /*
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = [.. matrix[i].Reverse()];
        }
        */
    }

    public static void Run()
    {
        // Create test cases
        List<int[][]> testCases =
        [
            [[1,2,3],[4,5,6],[7,8,9]],
            [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
        ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"TestCase Before:\n{MatrixToString(testCase)}");
            Rotate(testCase);
            Console.WriteLine($"TestCase After:\n{MatrixToString(testCase)}");
        }
    }

    public static string MatrixToString(int[][] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix[0].GetLength(0);
        StringBuilder sb = new();
        for (int i = 0; i < rows; i++)
        {
            sb.Append('[');
            for (int j = 0; j < columns; j++)
            {
                sb.Append(string.Format("{0,4}", matrix[i][j] + "\t"));
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(']');
            sb.AppendLine();
        }
        return sb.ToString();
    }
}