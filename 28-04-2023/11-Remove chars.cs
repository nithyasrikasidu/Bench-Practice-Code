using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _11_Remove_chars
    {
        public static void Main()
        {
            string str1, str2, result;
            Console.WriteLine("Enter the two strings");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            result = "";
            foreach(Char c in str1)
            {
                if(!str2.Contains(c)!)
                {
                    result += c;
                }
            }
            Console.WriteLine(result);

        }
    }
}
