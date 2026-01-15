namespace Leetcode2026.Neetcode150;

/*
  136. Single Number
Easy
Given a non-empty array of integers nums, every element appears twice except for one.
Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.

Example 1:

Input: nums = [2,2,1]

Output: 1

Example 2:

Input: nums = [4,1,2,1,2]

Output: 4

Example 3:

Input: nums = [1]

Output: 1

Constraints:

1 <= nums.length <= 3 * 10^4
-3 * 10^4 <= nums[i] <= 3 * 10^4
Each element in the array appears twice except for one element which appears only once.
*/

public static class Question144
{
    // Helper methods

    //Solution method
    public static int SingleNumber(int[] nums)
    {
        int n = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            n^=nums[i];
        }
        return n;
    }

    public static void Run()
    {
        // Create test cases
        List<int[]> testCases =
        [
            [2,2,1],
            [4,1,2,1,2],
            [1]
        ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"TestCase: [{string.Join(',', testCase)}] Ans: {SingleNumber(testCase)}");
        }
    }
}