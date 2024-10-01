using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicateDetectAndSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Please enter 5 unique numbers: ");

            while (numbers.Count < 5)
            {
                Console.Write($"Enter number {numbers.Count + 1}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Error: This number has already been entered. Please try again.");
                    }
                    else
                    {
                        numbers.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                }
            }

            numbers.Sort();
            Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));

            Console.ReadKey();
        }
    }
}
