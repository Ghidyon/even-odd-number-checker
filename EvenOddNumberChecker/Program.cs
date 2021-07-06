using System;

namespace EvenOddNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            int inputNumber = Convert.ToInt32(input);

            if (inputNumber % 2 != 0)
            {
                Console.WriteLine($"{inputNumber} is an odd number");
            }
            else
            {
                Console.WriteLine($"{inputNumber} is an even number");
            }
        }
    }
}
