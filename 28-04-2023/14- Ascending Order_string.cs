using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _14__Ascending_Order_string
    {
        public static void Main()
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            Console.WriteLine("Ascending order of the string");
            foreach (char c in ch)
                Console.WriteLine(c);

        }
    }
}
