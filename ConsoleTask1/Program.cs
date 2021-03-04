using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask1
{
    class Program
    {
        /// <summary>
        /// Call the library method Hypotenuse(b,c) with task1.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите катет b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите катет c");
            double c = int.Parse(Console.ReadLine());
            double a = task1.Task.Hypotenuse(b,c);

            
            Console.WriteLine("Hypotenuse= {0}", a);
            Console.ReadKey(); 
        }
    }
}
