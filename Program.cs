using System.Globalization;
using System.Reflection.Metadata;

namespace Assignment_1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            nums[0] = 2;
            nums[1] = 5;
            nums[2] = 7;

            Console.WriteLine("The values stored into the array are:");
            foreach ( int num in nums)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            // Array.Reverse(nums);

            for (int i = 0; i < nums.Length / 2; i++)
            {
                int temp = nums[i];
                nums[i] = nums[nums.Length - 1 - i];
                nums[nums.Length - 1 - i] = temp;
            }

            Console.WriteLine("The values stored into the array in reverse are:");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
        }
        
    }                                                                           
}
                                                     