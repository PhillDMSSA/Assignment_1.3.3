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

            Console.WriteLine("The values store into the array are:");
            foreach ( int num in nums)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            Array.Reverse(nums); //reserves Array

            Console.WriteLine("The values store into the array in reverse are:");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            




        }
    }                                                                           
}
                                                     