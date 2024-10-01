using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class DBConnection
    {
        private static DBConnection instance;

        private DBConnection() 
        {
            Console.WriteLine("Database connection established.");
        }

        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }
    }
}
