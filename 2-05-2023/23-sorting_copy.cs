﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _23_sorting_copy
    {
        public static void Main()
        {
            Console.WriteLine("Enter the array element");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("After sorting the array elements");
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1; j<arr.Length;j++)
                {
                    int temp = 0;
                    if (arr[i]>arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
            }
            int[] arr1 = new int[arr.Length];
            arr1 = arr;
            
            Console.WriteLine("copied elements of array 1 to array 2");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }

        }
    }
}
