﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _17_Sum_of_evens_and_odds
    {
        public static void Main()
        {
            int i, sum1 = 0, sum2 = 0;
            int[] j = new int[10];
            Console.WriteLine("enter any numbers");
            for(i = 0;i < 10;i++)
            {
                j[i] = Convert.ToInt32(Console.ReadLine());

                if(j[i]%2==0)
                {
                    sum1 += j[i];
                }
                else
                {
                    sum2 += j[i];
                }
            }
            Console.WriteLine($"Sum of even numbers:{sum1}");
            Console.WriteLine($"Sum of odd numbers:{sum2}");

        }
    }
}
