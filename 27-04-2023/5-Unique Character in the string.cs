using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Unique_Character_in_the_string
    {
        public static void Main()
        {
            string input;
            Console.WriteLine("enter the string");
            input = Console.ReadLine();
            char uniquechar = '\0';
            foreach(char c in input)
            {
                if (input.IndexOf(c) == input.LastIndexOf(c))
                {
                    uniquechar = c;
                    break;
                }
            }
            if(uniquechar == '\0')
            {
                Console.WriteLine("No unique character found");
            }
            else
            {
                Console.WriteLine("The unique number is:" + uniquechar);
            }
        }
    }
}
