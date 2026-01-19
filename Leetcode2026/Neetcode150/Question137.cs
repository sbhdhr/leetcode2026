using System.Text;

namespace Leetcode2026.Neetcode150;

/*
54. Spiral Matrix
Medium
Given an m x n matrix, return all elements of the matrix in spiral order.

Example 1:

Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]
Example 2:

Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 10
-100 <= matrix[i][j] <= 100
*/

public static class Question137
{
    // Helper methods

    //Solution method
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        int r = matrix.Length; //Initial possible number of steps
        int c = matrix[0].Length;
        int i = 0, j = -1, dir = 1;
        IList<int> res = [];

        while (r * c > 0)
        {
            for (int x = 0; x < c; x++) //horizontal
            {
                j += dir;
                res.Add(matrix[i][j]);
            }
            r--;
            for (int x = 0; x < r; x++) //horizontal
            {
                i += dir;
                res.Add(matrix[i][j]);
            }
            c--;
            dir *= -1;
        }

        return res;
    }

    public static void Run()
    {
        // Create test cases
        List<int[][]> testCases =
        [
            [[1,2,3],[4,5,6],[7,8,9]],
            [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
        ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"\nTestCase:\n{MatrixToString(testCase)}");
            Console.WriteLine($"Spiral Order: [{string.Join(",", SpiralOrder(testCase))}]");
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