using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _19_Leap_Year
    {
        public static void Main()
        {
            Console.WriteLine("Enter any year");
            int i = Convert.ToInt32(Console.ReadLine());
            if(i%4==0 &&((i%100!=0||i%400==0)))
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("it is not a leap year");
            }
                        

            
        }
    }
}
