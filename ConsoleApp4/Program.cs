using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввод х=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ввод у=");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}+{y}={Sum(x, y)}");
            Console.WriteLine($"{x}-{y}={Min(x, y)}");
            Console.WriteLine($"{x}*{y}={Um(x, y)}");
            Console.WriteLine($"{x}/{y}={Del(x, y):f2}");
            Console.ReadKey();
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Min(int x, int y)
        {
            return x - y;
        }
        public static int Um(int x, int y)
        {
            return x * y;
        }
        public static double Del(int x, int y)
        {
            return (double) x / y;
        }
    }
}
