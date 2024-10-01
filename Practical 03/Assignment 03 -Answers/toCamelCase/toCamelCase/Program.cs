using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toCamelCase
{
    class Program
    {

        public static string toCamelCase(string input)
        {
            string[] substrings = input.Split(' ');

            for (int i=0; i < substrings.Length; i++)
            {
                substrings[i] = char.ToUpper(substrings[i][0]) + substrings[i].Substring(1).ToLower();
            }
            return string.Join("", substrings);
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Error!");
                Console.ReadKey();
            }
            else
            {
                string camelCaseResult = toCamelCase(str);

                Console.WriteLine(camelCaseResult);
                Console.ReadKey();
            }
        }
    }
}
