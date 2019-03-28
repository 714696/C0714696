using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        static void Download()
        {
            Thread.Sleep(7000);
            Console.WriteLine("Download Complete");
        }
    }
}
