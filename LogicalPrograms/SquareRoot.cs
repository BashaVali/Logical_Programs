using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    /// <summary>
    /// The class is to execute the square root program using newtons method
    /// </summary>
    public class SquareRoot
    {
        /// <summary>
        /// This method calculates square root using Newtons method
        /// </summary>
        public static void Sqrt()
        {
            Console.WriteLine("Enter the value for which you want to get the squre root");
            int c = Convert.ToInt32(Console.ReadLine());
            float t = c;
            while (Math.Abs(t - (c / t)) > 1e-15)
            {
                t = ((c / t) + t) / 2;
            }

            Console.WriteLine("The squre root of c is " + t);
        }
    }
}