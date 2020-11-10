using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkStationName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WorkStation Name:" + Environment.MachineName+"\n");
            Console.WriteLine("FQDN: " + System.Net.Dns.GetHostName()+"\n");

            Console.WriteLine("Please press a key to exit...");
            Console.ReadLine();
        }
    }
}
