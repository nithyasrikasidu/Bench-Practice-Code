﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Sumofconsecutivenumbers
    {
        public static void Main()
        {

            int[]arr = new int[5];
            int i;
            int[] j = new int[4];
            Console.WriteLine("Enter elements into an array");
            for(i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"sum of all the elements in the array was{arr.Sum()}");
            for(i=0;i<arr.Length-1;i++)
            {
                j[i] = arr[i] + arr[i + 1];
            }
            Console.WriteLine($"sum of all the consecutive numbers in an array was{j.Min()}");
        }
    }
}
