using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        public static void Func()
        {
            Console.Write("a=");
            int x = int.Parse(Console.ReadLine());
            double b = 12 * Math.Pow(x, 2) + 7 * x - 6;
            Console.WriteLine($"b={b:f2}");

        }
    }
}
