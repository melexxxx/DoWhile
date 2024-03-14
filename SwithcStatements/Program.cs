using System;

namespace BooleanComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while statement
            int number = 5;
            int target = 10;

            Console.WriteLine("While Loop:");
            while (number < target) // While number is less than target
            {
                Console.WriteLine($"Number: {number}");
                number++; // Increment number
            }

            Console.WriteLine("\n--------------------------\n");

            // Boolean comparison using a do-while statement
            int count = 0;

            Console.WriteLine("Do-While Loop:");
            do
            {
                Console.WriteLine($"Count: {count}");
                count++; // Increment count
            } while (count < 5); // Do this while count is less than 5
        }
    }
}
