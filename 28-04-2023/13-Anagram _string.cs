using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _13_Anagram__string
    {
        public static void Main()
        {
            string str1, str2;
            Console.WriteLine("Enter the two strings");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            char[] ch1= str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string value1 = new string(ch1);
            string value2 = new string(ch2);
            if(value1==value2)
            {
                Console.WriteLine("Both strings are anagram");
            }
            else
            {
                Console.WriteLine("Both strings are not anagram");
            }
        }
    }
}
