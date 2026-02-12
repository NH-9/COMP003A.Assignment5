using System;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = false;
            do
            {
                ProgramIntroduction();

                Console.Write("\nEnter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter a number: ");
                int numA = int.Parse(Console.ReadLine());
                UserInputHandling(name, numA);

                int numDouble = CalculationLogic(numA);
                Console.WriteLine($"\n{numA} doubled is {numDouble}");

                if (numDouble > 50)
                {
                    Console.WriteLine($"{numDouble} is greater than 50");
                }
                else
                {
                    Console.WriteLine($"{numDouble} is not greater than 50");
                }

                Console.Write("\nWould you like to run this program again? (y/n): ");
                keepGoing = Console.ReadLine().ToLower() == "y";

                Console.WriteLine();
            }
            while (keepGoing);
        }

        static void ProgramIntroduction()
        {
            Console.WriteLine("Welcome to the 5th assignment!");
        }

        static void UserInputHandling(string name, int number)
        {
            Console.WriteLine($"Name: {name}, Number: {number}");
        }

        static int CalculationLogic(int number)
        {
            return number * 2;
        }
    }
}
