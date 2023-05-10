using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _26_Primefactors
    {
        public static void Main()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors of given number are");
            for(int i=2;i<=num;i++)
            {
                while(num%i==0)
                {
                    Console.WriteLine(i + "");
                    num /= i;
                }
            }
            Console.WriteLine();
        }
    }
}
