using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _34_Even_Odd_In_an_Array
    {
        public static void Main()
        {
            Console.WriteLine("enter the length of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("The array elements are");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The even numbers in the given array");
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2==0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine("The odd numbers in the given array");
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2!=0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
