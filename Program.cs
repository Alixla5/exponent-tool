using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        char choice;
        int number;
        bool validInput;
        do //do while
        {
            Console.WriteLine("Hello let's enter a new number\n");

          
            do
            {
                Console.Write("Enter a whole number ");
                validInput = int.TryParse(Console.ReadLine(), out number);
                if (!validInput || number <= 0) //if statement
                {
                    Console.WriteLine("That's not right, try again!");
                    validInput = false;
                }
            } while (!validInput);
            Console.WriteLine("\nNumber\t\tSquare\t\tCube");
            Console.WriteLine("=======\t\t=======\t\t=======");
            int maxNumber = (int)Math.Floor(Math.Pow(int.MaxValue, 1.0 / 3.0));
            for (int i = 1; i <= number && i <= maxNumber; i++) //for loop
            {
                Console.WriteLine($"{i}\t\t{i * i}\t\t{i * i * i}");
            }
            Console.Write("\nDo you want to continue? (yes/no): ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
        } while (char.ToLower(choice) == 'y');
    }
}



  