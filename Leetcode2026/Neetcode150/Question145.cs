using System.Numerics;

namespace Leetcode2026.Neetcode150;

/*
191. Number of 1 Bits
Easy
Given a positive integer n, write a function that returns the number of set bits in its binary
representation (also known as the Hamming weight).

Example 1:

Input: n = 11

Output: 3

Explanation:

The input binary string 1011 has a total of three set bits.

Example 2:

Input: n = 128

Output: 1

Explanation:

The input binary string 10000000 has a total of one set bit.

Example 3:

Input: n = 2147483645

Output: 30

Explanation:

The input binary string 1111111111111111111111111111101 has a total of thirty set bits.

Constraints:

1 <= n <= 2^31 - 1

Follow up: If this function is called many times, how would you optimize it?
*/

public static class Question145
{
    // Helper methods

    //Solution method
    public static int HammingWeight(int n)
    {
        //https://stackoverflow.com/questions/4678333/n-n-1-what-does-this-expression-do#:~:text=%3C%2D%2D%2D%2D%2D%20binary,power%20of%202%20or%200.
        //return BitOperations.PopCount(n);
        int count = 0;
        while (n != 0)
        {
            n &= (n - 1);
            count++;
        }
        return count;
    }

    public static void Run()
    {
        // Create test cases
        List<int> testCases =
        [
            11,
            128,
            2147483645
        ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"TestCase: [{testCase}] Ans: {HammingWeight(testCase)}");
        }
    }
}