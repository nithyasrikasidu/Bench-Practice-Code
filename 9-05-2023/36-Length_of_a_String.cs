using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _36_Length_of_a_String
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            int str1 = str.Length;
            int len = 0;
            for (int i = 0; i <= str1; i++)
            {
                len = i++;
            }
            Console.WriteLine("Length of the given string is " + len);
        }
    }
}
