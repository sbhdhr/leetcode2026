namespace Leetcode2026.Neetcode150;

/*
371. Sum of Two Integers
Medium

Given two integers a and b, return the sum of the two integers without using
the operators + and -.

Example 1:

Input: a = 1, b = 2
Output: 3
Example 2:

Input: a = 2, b = 3
Output: 5

Constraints:

-1000 <= a, b <= 1000
*/

public static class Question149
{
    // Helper methods

    //Solution method
    public static int GetSum(int a, int b)
    {
        // Convert to bits
        // Use Full Adder equations to generate the number
        return a+b;
    }

    public static void Run()
    {
        // Create test cases
        List<Tuple<int,int>> testCases =
        [
            new(1,2),
            new(2,3)
        ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"TestCase: [{string.Join(",", testCase)}] Ans: [{GetSum(testCase.Item1, testCase.Item2)}]");
        }
    }
}