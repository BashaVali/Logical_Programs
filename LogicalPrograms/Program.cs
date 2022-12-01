using LogicalProblems;
using LogicalPrograms;
using System;

namespace LogicalProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("-------LogicalProblems ------");
                Console.WriteLine("Select the option");
                Console.WriteLine("1.FibonacciSeries" + "\n" +
                                  "2.PerfectNumber" + "\n" +
                                  "3.PrimeNumber" + "\n" +
                                  "4.ReverseNumber" + "\n " +
                                  "5.CouponNumber" + "\n " +
                                  "6.Exit" + "\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        Console.WriteLine("\n\n" + "Enter the FibonacciSeries Value" + "\n");
                        int range = Convert.ToInt32(Console.ReadLine());
                        series.Print(range);
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        Console.WriteLine("\n" + "Check the Number Perfect or Not" + "\n");
                        Console.WriteLine("Enter the Value" + "\n");
                        int value = Convert.ToInt32(Console.ReadLine());
                        perfectNumber.Check(value);
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        Console.WriteLine("Enter the Value to check Prime" + "\n\n");
                        int value1 = Convert.ToInt32(Console.ReadLine());
                        primeNumber.CheckPrime(value1);
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        Console.WriteLine("Enter the Value to Reverse" + "\n\n");
                        int value2 = Convert.ToInt32(Console.ReadLine());
                        reverseNumber.Reverse(value2);
                        break;
                    case 5:
                        CouponNumber couponNumber = new CouponNumber();
                        Console.WriteLine("\n" + "Enter the Coupon Number" + "\n");
                        int num = Convert.ToInt32(Console.ReadLine());
                        CouponNumber.GenerateCoupons(num);
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}