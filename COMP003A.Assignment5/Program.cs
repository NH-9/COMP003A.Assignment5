using System;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction();
            bool keepGoing = false;

            // this loop execute the program once then allows the user to decide rather to execute it again or to stop the program
            do
            {
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
                if (!keepGoing)
                {
                    Console.WriteLine("\nProgram ended.");
                }

                Console.WriteLine();
            }
            while (keepGoing);
        }

        // this method allows Main to easily print an introduction to the program
        static void ProgramIntroduction()
        {
            Console.WriteLine("Welcome to the 5th assignment!");
        }

        // this method receives variables in order to print a dynamic message
        // due to scope rules, any string or interger pair will be processed without issue
        static void UserInputHandling(string name, int number)
        {
            Console.WriteLine($"Name: {name}, Number: {number}");
        }

        // this method calculates the double of a given number for use in Main
        // this can be reused for any interger variable
        static int CalculationLogic(int number)
        {
            return number * 2;
        }
    }
}
