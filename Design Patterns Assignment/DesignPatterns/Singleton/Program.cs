using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBConnection connection1 = DBConnection.getInstance();
            DBConnection connection2 = DBConnection.getInstance();

            if (connection1 == connection2) 
            { 
                Console.WriteLine("Both are the same instance."); 
            }
            else
            {
                Console.WriteLine("Different instances.");
            }

            Console.ReadKey();
        }
    }
}
