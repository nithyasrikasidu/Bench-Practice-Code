using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _15_Ascending_Order_number
    {
        public static void Main()
        {
            Console.Write("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            string num1 = num.ToString();
            char[] digits = num1.ToCharArray();
            Array.Sort(digits);
            Console.WriteLine("Ascending order of a number is");
            foreach(char d in digits )
            {
                Console.WriteLine(d);
            }
        }
    }
}
