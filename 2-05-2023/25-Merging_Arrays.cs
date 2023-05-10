using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _25_Merging_Arrays
    {
        public static void Main()
        {
            Console.WriteLine("Enter the arrays length");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr1 = new int[n];
            Console.WriteLine("The first array elements are");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The second array elements are");
            for(int i=0;i<arr.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr3 = new int[arr.Length + arr1.Length];
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                arr3[i] = arr[i];
                count++;
            }
            for(int i=0;i<arr1.Length;i++)
            {
                arr3[count++] = arr1[i];
            }
            Console.WriteLine("The merging of two arrays are");
            for(int i=0;i<arr3.Length;i++)
            {
                Console.WriteLine(arr3[i] + "");
            }
        }
    }
}
