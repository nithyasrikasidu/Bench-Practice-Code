using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _16_Average_of_10_numbers
    {
        public static void Main()
        {
            int[] j = new int[10];
            Console.WriteLine("Enter any ten Numbers:");
            for (int i = 0; i < 10; i++)
            {
                j[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Sum of all numbers was :{j.Sum()}");
            Console.WriteLine($"Average of numbers :{j.Sum() / j.Length}");



        }
    }
}
