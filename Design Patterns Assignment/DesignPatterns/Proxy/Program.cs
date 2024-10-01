using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        // SUBJECT INTERFACE
        public interface IInternet
        {
            void ConnectTo(string host);
        }

        // REAL SUBJECT CLASS
        public class RealInternet : IInternet
        {
            public void ConnectTo(string host) 
            { 
                Console.WriteLine($"Connected to the internet... Hostname: {host}");           
            }
        }

        // PROXY CLASS
        public class ProxyInternet : IInternet
        {
            private RealInternet realInternet;
            private static List<string> restrictedSites = new List<string>()
            {
                "bannedsite.com",
                "restrictedsite.net",
                "blockedsite.org"
            };

            public ProxyInternet()
            {
                realInternet = new RealInternet();
            }

            public void ConnectTo(string host)
            {
                if (restrictedSites.Contains(host))
                {
                    throw new Exception($"Access denied to {host}.");
                }
                realInternet.ConnectTo(host);
            }
        }

        static void Main(string[] args)
        {
            IInternet internet = new ProxyInternet();

            try
            {
                internet.ConnectTo("example.com");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                internet.ConnectTo("bannedsite.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
