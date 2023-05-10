using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _21_not_repeated_digits_in_array
    {
        public static void Main()
        {
            int j, k;
            int[] array = new int[5];
            Console.WriteLine("Enter the digits");
            for(int i=0;i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(j=0;j<array.Length;j++)
            {
                for(k=0;k<array.Length;k++)
                {
                    if (array[j] == array[k] && (j != k))
                        break;
                }
                if(k==array.Length)
                {
                    Console.WriteLine("Non repeated digits are" + array[j]);
                }
            }
        }
    }
}
