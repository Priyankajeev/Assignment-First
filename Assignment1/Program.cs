using System;

namespace Assignment1_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Take the user input for number to be printed
            Console.Write("Enter the number to be printed: ");
            int number = int.Parse(Console.ReadLine());

            // Take the user input for width of triangle
            Console.Write("Enter the width of triangle: ");
            int width = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= width; i++)          // controls how many rows will be printed
            {
                for (int j = 1; j <= i; j++)          // number of times to print the number per row
                {
                    Console.Write(number + " ");      //to print the number with a space.
                }
                Console.WriteLine();                 //to move to the next line after each row
            }

            Console.ReadKey();
        }
    }
}
