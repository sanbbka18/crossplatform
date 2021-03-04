using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask3
{
    class Program
    {
        /// <summary>
        /// call the library method Sum(ε) with Class1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите показатель ε:");
            int ε = int.Parse(Console.ReadLine());
            double x = 6.6;
            double Sum = task3.Class1.T3(ε);
            double F = (Math.Pow(Math.PI, 2) / 8) - ((Math.PI * Math.Abs(x)) / 4);
            double t = (Math.Abs(Sum - F) / F)*1;

            Console.WriteLine("Sum = {0},F = {1},t = {2}", Sum,F,t);
            Console.ReadKey();
        }
    }
}
