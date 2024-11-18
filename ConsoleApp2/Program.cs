using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввод х=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ввод у=");
            int y = int.Parse(Console.ReadLine());
            Console.Write($"sum={Sum(x, y)}");
            Console.ReadKey();
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }

    }
}
