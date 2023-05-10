using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _30_Armstrong_Number
    {
        public static void Main()
        {
            //int n, rem, sum = 0;
            //Console.WriteLine("Enter any number:");
            //n = Convert.ToInt32(Console.ReadLine());
            //int temp = n;
            //while (n > 0)
            //{
            //    rem = n % 10;
            //    sum = sum + (rem * rem * rem);
            //    n = n / 10;
            //}
            //if (temp == sum)
            //{
            //    Console.WriteLine("The given number is Armstrong number");
            //}
            //else
            //{
            //    Console.WriteLine("The given number is not armstrong number");
            //}
            int n, rem, sum = 0;
            Console.WriteLine("Enter any number:");
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("The given number is Armstrong number");
            }
            else
            {
                Console.WriteLine("The given number is not armstrong number");
            }
        }
    }
}
