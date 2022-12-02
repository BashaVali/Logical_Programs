using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class TemperatureConversion
    {
        public static void TemperatureConvert(int num)
        {
            Console.WriteLine("Select 1-Celsius to Fahrenheit , 2-Fahrenheit to Celsius");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    float fahrenheit = (num * (9 / 5f)) + 32;
                    Console.WriteLine("{0}C into fahrenheit is {1}F", num, fahrenheit);
                    break;
                case 2:
                    float celcius = (num - 32) * (5 / 9f);
                    Console.WriteLine("{0}F into Celsius is {1}C", num, celcius);
                    break;
            }
        }
    }
}