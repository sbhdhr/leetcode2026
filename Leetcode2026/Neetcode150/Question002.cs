namespace Leetcode2026.Neetcode150;

/*
  242. Valid Anagram
    Easy
    Given two strings s and t, return true if t is an anagram of s, and false otherwise.

 

    Example 1:

    Input: s = "anagram", t = "nagaram"

    Output: true

    Example 2:

    Input: s = "rat", t = "car"

    Output: false

 

    Constraints:

    1 <= s.length, t.length <= 5 * 10^4
    s and t consist of lowercase English letters.
*/

public static class Question002
{
    // Helper methods


    //Solution method
    public static bool IsAnagram(string s, string t)
    {
        int[] arr = [.. Enumerable.Repeat(0, 26)];
        foreach (var c in s)
        {
            arr[c-'a']++;
        }
        foreach (var c in t)
        {
            arr[c-'a']--;
        }
        foreach (var i in arr)
        {
            if (i != 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void Run()
    {
        // Create test cases
        List<Tuple<string, string>> testCases = new()
        {
            new("anagram", "nagaram"),
            new("rat", "car"),
            new("a","ab")
        };

        // Execute the method
        foreach (var testCase in testCases)
        {
            if (IsAnagram(testCase.Item1, testCase.Item2))
            {
                Console.WriteLine($"TestCase: [{string.Join(',', testCase.Item1, testCase.Item2)}] Ans: Is an anagram");
            }
            else
            {
                Console.WriteLine($"TestCase: [{string.Join(',', testCase.Item1, testCase.Item2)}] Ans: Not an anagram");
            }
        }
    }
}

