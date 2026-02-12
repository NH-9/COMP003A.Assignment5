using System;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction();

            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a number: ");
            int numA = int.Parse(Console.ReadLine());
            UserInputHandling(name, numA);


        }

        static void ProgramIntroduction()
        {
            Console.WriteLine("Welcome to the 5th assignment!");
        }

        static void UserInputHandling(string name, int number)
        {
            Console.WriteLine($"Name: {name}, Number: {number}");
        }
    }
}
