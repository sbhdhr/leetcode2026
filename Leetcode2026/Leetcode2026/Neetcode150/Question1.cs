namespace Leetcode2026.Neetcode150
{
    /* Question 1
     * 
     * Description:
     * Implement the solution for Question 1 here.
     * 
     */
    public static class Question1
    {
        // Helper methods


        //Solution method
        public static bool ContainsDuplicate(List<int> nums)
        {
            
            return false;
        }

        public static void Run()
        {
            // Create test cases
            List<int> nums = [ 1, 2, 3, 1 ];



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
}
