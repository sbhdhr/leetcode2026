namespace Leetcode2026.Neetcode150;

/*
50. Pow(x, n)
Medium
Implement pow(x, n), which calculates x raised to the power n (i.e., xn).

Example 1:

Input: x = 2.00000, n = 10
Output: 1024.00000

Example 2:

Input: x = 2.10000, n = 3
Output: 9.26100

Example 3:

Input: x = 2.00000, n = -2
Output: 0.25000
Explanation: 2^-2 = 1/2^2 = 1/4 = 0.25

Constraints:

-100.0 < x < 100.0
-2^31 <= n <= 2^31-1
n is an integer.
Either x is not zero or n > 0.
-10^4 <= xn <= 10^4
*/

public static class Question141
{
    // Helper methods
    private static double binaryExp(double x, long n)
    {
        if (n == 0)
        {
            return 1.0;
        }
        if (n < 0)
        {
            return 1 / binaryExp(x, -n);
        }

        if (n % 2 == 1)//n is odd
        {
            return x * binaryExp(x * x, (n - 1) / 2);
        }
        return binaryExp(x * x, n / 2);
    }

    //Solution method
    public static double MyPow(double x, int n)
    {
        return binaryExp(x, (long)n);
    }

    public static void Run()
    {
        // Create test cases
        List<(double x, int n)> testCases =
        [
            new(2,10),
            new(2.1,3),
            new(2,-2)
        ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"TestCase <{testCase}>: Result: {MyPow(testCase.x, testCase.n)}");
        }
    }
}