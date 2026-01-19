using System.Text;

namespace Leetcode2026.Neetcode150;

/*
73. Set Matrix Zeroes
Medium
Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.

You must do it in place.

Example 1:

Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
Output: [[1,0,1],[0,0,0],[1,0,1]]
Example 2:

Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]

Constraints:

m == matrix.length
n == matrix[0].length
1 <= m, n <= 200
-2^31 <= matrix[i][j] <= 2^31 - 1

Follow up:

A straightforward solution using O(mn) space is probably a bad idea.
A simple improvement uses O(m + n) space, but still not the best solution.
Could you devise a constant space solution?
*/

public static class Question138
{
    // Helper methods

    //Solution method
    public static void SetZeroes(int[][] matrix)
    {
        int r = matrix.Length;
        int c = matrix[0].Length;

        HashSet<int> hsR = [];
        HashSet<int> hsC = [];

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (matrix[i][j] == 0)
                {
                    hsR.Add(i);
                    hsC.Add(j);
                }
            }
        }

        foreach (int i in hsR)
        {
            for (int j = 0; j < c; j++)
            {
                matrix[i][j] = 0;
            }
        }

        foreach (int j in hsC)
        {
            for (int i = 0; i < r; i++)
            {
                matrix[i][j] = 0;
            }
        }
    }

    public static void Run()
    {
        // Create test cases
        List<int[][]> testCases =
        [
            [[1,1,1],[1,0,1],[1,1,1]],
            [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
        ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"TestCase Before:\n{MatrixToString(testCase)}");
            SetZeroes(testCase);
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