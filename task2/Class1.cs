using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    ///calculation of mathematical functions
    public class Class1
    {
        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="n">to find the sum of n members of a series</param>
        /// <returns>starts the cycle of finding the amount</returns>
        public static double sum( int n)
        {
            double x = 0.5;
            double S = 0;
            for (int i = 1; i < n; i++)
            {
                S = S + Math.Pow(-1,i-1)*(Math.Sin(i*x)/(i));
            }
            return S;
        }

        

    }
}
