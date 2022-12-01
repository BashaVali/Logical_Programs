﻿using LogicalProblems;
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
                                  "3.Exit" + "\n");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}