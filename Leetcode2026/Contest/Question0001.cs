namespace Leetcode2026.Contest;

/*
Q1. Absolute Difference Between Maximum and Minimum K Elements
Easy
You are given an integer array nums and an integer k.

Find the absolute difference between:

the sum of the k largest elements in the array; and
the sum of the k smallest elements in the array.
Return an integer denoting this difference.

 

Example 1:

Input: nums = [5,2,2,4], k = 2

Output: 5

Explanation:

The k = 2 largest elements are 4 and 5. Their sum is 4 + 5 = 9.
The k = 2 smallest elements are 2 and 2. Their sum is 2 + 2 = 4.
The absolute difference is abs(9 - 4) = 5.
Example 2:

Input: nums = [100], k = 1

 */

public class Question0001
{
    public static int AbsDifference(int[] nums, int k)
    {
        PriorityQueue<int, int> pqMax = new();

        PriorityQueue<int, int> pqMin = new();

        foreach (int i in nums)
        {
            pqMax.Enqueue(i, -i);
            pqMin.Enqueue(i, i);
            if (pqMax.Count > k)
            {
                pqMax.Dequeue();
                pqMin.Dequeue();
            }
        }

        int maxSum = pqMax.UnorderedItems.Sum(item => item.Element);
        int minSum = pqMin.UnorderedItems.Sum(item => item.Element);

        return Math.Abs(maxSum - minSum);
    }

    public static void Run()
    {
        // Create test cases
        List<Tuple<int[], int>> testCases = [
            new Tuple<int[],int>([5,2,2,4],3),
            new Tuple<int[],int>([100],1)
            ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"TestCase: [{string.Join(',', testCase)}] Ans: {AbsDifference(testCase.Item1, testCase.Item2)}");
        }
    }
}