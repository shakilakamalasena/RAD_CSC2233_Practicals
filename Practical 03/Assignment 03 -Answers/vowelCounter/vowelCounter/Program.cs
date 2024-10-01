using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelCounter
{
    class Program
    {

        public static int vowelCount(string input)
        {
            int count = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i=0; i<input.Length; i++)
            {
                if(vowels.Contains(input[i]))
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(vowelCount(input));
            Console.ReadKey();
        }
    }
}
