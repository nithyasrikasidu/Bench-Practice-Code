using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _35_Rotation_of_elements_left_right
    { 
        public static void Main()
        {
            Console.WriteLine("Enter the length of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("The array elemnts are");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            _35_Rotation_of_elements_left_right array = new _35_Rotation_of_elements_left_right();
            array.LeftRotation(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



        }



        private void LeftRotation(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[(arr.Length - 1)] = x;
        }
    }
    
}
