namespace Leetcode2026.Neetcode150;

/*
190. Reverse Bits
Reverse bits of a given 32 bits signed integer.

Example 1:

Input: n = 43261596

Output: 964176192

Explanation:

Integer	Binary
43261596	00000010100101000001111010011100
964176192	00111001011110000010100101000000
Example 2:

Input: n = 2147483644

Output: 1073741822

Explanation:

Integer	Binary
2147483644	01111111111111111111111111111100
1073741822	00111111111111111111111111111110

Constraints:

0 <= n <= 2^31 - 2
n is even.

Follow up: If this function is called many times, how would you optimize it?
*/

public static class Question147
{
    // Helper methods

    //Solution method
    public static int ReverseBits(int n)
    {
        var result = 0;
        var bits = 31;
        while (bits > 0)
        {
            result = result | n & 1;
            n = n >> 1;

            result = result << 1;
            bits--;
        }
        return result;

        //var nStr = Convert.ToString(n,2).PadLeft(32,'0');
        ////Console.WriteLine("N: " + nStr);
        //var revStr = new string([.. nStr.Reverse()]);
        ////Console.WriteLine("R: " + revStr);

        //return Convert.ToInt32(revStr, 2);

        //Console.WriteLine("R AM: " + Convert.ToString(res, 2).PadLeft(32, '0'));
        //Console.WriteLine("R B: " + Convert.ToString(res, 2).PadLeft(32, '0'));
        //Console.WriteLine("Bit extracted: " + ((n & 1)));
        //Console.WriteLine("R A: " + Convert.ToString(res, 2).PadLeft(32, '0'));
        //Console.WriteLine("N B: " + Convert.ToString(n, 2).PadLeft(32, '0'));
        //Console.WriteLine("N A: " + Convert.ToString(n, 2).PadLeft(32, '0'));
    }

    public static void Run()
    {
        // Create test cases
        List<int> testCases =
        [
            43261596,
            2147483644
        ];

        // Execute the method
        foreach (var testCase in testCases)
        {
            Console.WriteLine($"TestCase: [{testCase}] Ans: [{ReverseBits(testCase)}]");
        }
    }
}