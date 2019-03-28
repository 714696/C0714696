using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections;


namespace C0714696
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peter Rules IT universe!");
            Download();
            Console.ReadLine();

        }

        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://ibm.com");
            Console.WriteLine(data);
            // To Do: Store each kine of the webpage into an entry
            // in a List
           
            List myList = new List();

        }
        class Network
        {
            static public Task Download()
            {
                return Task.Run(() => Thread.Sleep(3000));
            }
        }
    }
}
