using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Repeated_Character
    {
        public static void Main()
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            char rptchar = '\0';
            for(int i=0;i<input.Length;i++)
            {
                char currentchar = input[i];
                if(input.IndexOf(currentchar) != input.LastIndexOf(currentchar))
                {
                    rptchar = currentchar;
                    break;
                }
            }
            if(rptchar=='\0')
            {
                Console.WriteLine("No repeat character is found");
            }
            else
            {
                Console.WriteLine("First repeated character is" + rptchar);
            }
        }

    }
}
