using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniqueNumberCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();
            Console.WriteLine("Enter numbers continuously. Type 'Quit' to exit.");

            while (true)
            {
                Console.WriteLine("Enter a number (or type 'Quit' to exit): ");
                string input = Console.ReadLine();

                if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    int number = int.Parse(input);
                    uniqueNumbers.Add(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid number or type 'Quit' to exit.");
                }
            }

            Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));
            Console.ReadKey();
        }
    }
}
