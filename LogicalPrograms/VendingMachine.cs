using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class VendingMachine
    {
        int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        int[] currency = new int[8];
        int count = 0;
        public void Change(int amount)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                if (amount / notes[i] >= 1)
                {
                    currency[count] = notes[i];
                    count++;
                    amount -= notes[i];
                    if (amount != 0)
                    {
                        this.Change(amount);
                    }
                    else
                        return;
                    break;
                }
                else
                    continue;
            }
            if (count > 0)
                Console.WriteLine("Number of notes required is: " + count);
        }
        public void Print()
        {
            int prev = 0;
            for (int i = 0; i < currency.Length; i++)
            {
                int count = 0;
                if (currency[i] != 0)
                {
                    foreach (var data in currency)
                    {
                        if (currency[i] == data && data != prev)
                        {
                            count++;
                        }
                    }
                    prev = currency[i];
                    if (count > 0)
                    {
                        Console.WriteLine(count + ":" + currency[i]);
                    }
                }
            }
        }
    }
}