using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    ///calculation of mathematical functions
    public class Class1
    {
        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="ε">to find the sum of n members of a series</param>
        /// <returns>starts the cycle of finding the amount</returns>
        public static double T3(int ε)
        {
            double x = 6.6;
            double Sum = 0;
            for (int i = 1; i <= ε; i++)
            {
                Sum = Sum + Math.Sin(2 * i * x - 1);
            }
           return Sum;     
        }
    }
}

       
          
        
    