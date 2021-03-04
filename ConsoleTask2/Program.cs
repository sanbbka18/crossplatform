using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        /// <summary>
        /// call the library method sum(n) with Class1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите показатель n:");
            int n = int.Parse(Console.ReadLine());
            double S = task2.Class1.sum(n);

            Console.WriteLine("S = {0}", S);
            Console.ReadKey();
        }
    }
}
