using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class string_into_integer
    {
        public static void Main()
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            int num = int.Parse(str);
            Console.WriteLine(num);

        }
    }
}
