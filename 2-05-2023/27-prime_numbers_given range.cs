using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace Programs
{
    class _27_prime_numbers_given_range
    {
       public static void Main()
        {
            int count;
            int i, j, a, b;
            Console.WriteLine("ENTER THE RANGE");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (i = a; i <= b; i++)
            {
                count = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                    Console.WriteLine(i);
            }
        }

    }
}
