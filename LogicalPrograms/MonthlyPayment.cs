using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthlyPayments
    {    
            public static void MonthlyPayment(int P, int R, int Y)
            {
                float r = (float)R / (12 * 100);
                int n = 12 * Y;
                double payment = (P * r) / (1 - (Math.Pow((1 + r), -n)));
                Console.WriteLine("Monthly payment for " + Y + " years  " + payment);

            }
        }
    }