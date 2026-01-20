namespace Leetcode2026.Neetcode150;

/*
202. Happy Number
Easy
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.

Example 1:

Input: n = 19
Output: true
Explanation:
1^2 + 9^2 = 82
8^2 + 2^2 = 68
6^2 + 8^2 = 100
1^2 + 0^2 + 0^2 = 1

Example 2:

Input: n = 2
Output: false

Constraints:

1 <= n <= 2^31 - 1
*/

public static class Question139
{
    // Helper methods

    //Solution method
    public static bool IsHappy(int n)
    {
        int t = n;
        HashSet<int> hs = [];
        while (true)
        {
            int sum = 0;
            while (t > 0)
            {
                int d = t % 10;
                t = t / 10;
                sum += d * d;
            }
            if (sum == 1)
            {
                return true;
            }
            if (hs.Contains(sum))
            {
                return false;
            }
            hs.Add(sum);
            t = sum;
        }
    }

    public static void Run()
    {
        // Create test cases
        List<int> testCases =
        [
            19,
            2
        ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"TestCase {testCase}: Result: {IsHappy(testCase)}");
        }
    }
}