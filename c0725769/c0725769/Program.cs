using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c0725769
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Download();
            Console.ReadLine();
        }
        static void Download() {
            Thread.Sleep(4000);
            Console.WriteLine("downloading start");
        }
    }
}
