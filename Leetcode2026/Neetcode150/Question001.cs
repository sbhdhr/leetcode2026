namespace Leetcode2026.Neetcode150;

/*
  217. Contains Duplicate
  Easy

  Given an integer array nums, return true if any value appears at least twice 
  in the array, and return false if every element is distinct.



  Example 1:

  Input: nums = [1,2,3,1]

  Output: true

  Explanation:

  The element 1 occurs at the indices 0 and 3.

  Example 2:

  Input: nums = [1,2,3,4]

  Output: false

  Explanation:

  All elements are distinct.

  Example 3:

  Input: nums = [1,1,1,3,3,4,3,2,4,2]

  Output: true



  Constraints:

  1 <= nums.length <= 10^5
  -10^9 <= nums[i] <= 10^9
*/

public static class Question001
{
    // Helper methods


    //Solution method
    public static bool ContainsDuplicate(List<int> nums)
    {
        HashSet<int> seen = [];
        foreach (int num in nums)
        {
            if (seen.Contains(num))
            {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }

    public static void Run()
    {
        // Create test cases
        List<int> nums = [1, 2, 3, 1];



        // Execute the method
        if (ContainsDuplicate(nums))
        {
            Console.WriteLine("Contains duplicate");
        }
        else
        {
            Console.WriteLine("No duplicates");
        }
    }
}

