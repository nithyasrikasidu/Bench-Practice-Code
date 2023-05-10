using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _18_no_of_times_A
    {
        public static void Main()
        {
            int count = 0;
            Console.WriteLine("Enter the string");
            String string1 = Console.ReadLine();
            char[] c = string1.ToCharArray();
            for(int i=0;i<string1.Length;i++)
            {
                if(c[i]=='a')
                {
                    count++;
                }
            }
            if(count==0)
            {
                Console.WriteLine("No 'a's are found");
            }
            else
            {
                Console.WriteLine($"Number of 'a's are present was:{count}");
            }
        }
    }
}
