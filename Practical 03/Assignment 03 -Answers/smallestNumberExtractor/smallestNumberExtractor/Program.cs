using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallestNumberExtractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers (e.g. 5, 1, 9, 2, 10): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid List. Please try again.");
                    continue;
                }

                string[] parts = input.Split(',');
                List<int> numbers = new List<int>();

                foreach (var part in parts)
                {
                    if (int.TryParse(part.Trim(), out int number))
                    {
                        numbers.Add(number);
                    }
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please try again.");
                    continue;
                }

                numbers.Sort();
                List<int> smallestNumbers = numbers.Take(3).ToList();

                Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
                break;
            }

            Console.ReadKey();
        }
    }
}
