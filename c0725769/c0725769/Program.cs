using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

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
        static async void Download() {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://facebook.com");
            Console.WriteLine(data);
           
        }
        class Network
        {

            static public Task Download() {

                return Task.Run( ()=> Thread.Sleep(3000));
            }
        }
    }
}
