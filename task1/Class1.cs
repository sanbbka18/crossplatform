using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    ///calculation of mathematical functions
    public class Task
    {
        /// <summary>
        /// Hypotenuse
        /// </summary>
        /// <param name="b"> the first leg of the triangle</param>
        /// <param name="c">the second leg of the triangle</param>
        /// <returns>returns the value of Hyp for a right triangle</returns>
        /// 
        public static double Hypotenuse(double b, double c)
        {
           double Hyp ;
            Hyp = Math.Sqrt(Math.Pow(b, 2)+ Math.Pow(c, 2));
            return Hyp;
        }

    }
}
