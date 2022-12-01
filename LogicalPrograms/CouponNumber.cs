using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumber
    {
        public static int count = 0;
        public static int GenerateRandom()
        {

            Random random = new Random();
            int randomNum = random.Next(0, 11);
            return randomNum;
        }
        public static void GenerateCoupons(int num)//10
        {
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                int random = GenerateRandom();//1
                for (int j = 0; j < num; j++)//2,1
                {
                    if (arr[j] == random)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    arr[i] = random;
                }
                foreach (var data in arr)
                {
                    if (data != 0)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
        }
    }
}