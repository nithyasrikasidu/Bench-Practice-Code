using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class diff_between_euals
    {
        public static void Main()
        {
            string name1, name2;
            Console.WriteLine("enter the two names");
            name1 = Console.ReadLine();
            name2 = Console.ReadLine();
            if(name1.Equals(name2))
            {
                Console.WriteLine("Both names are Equal");
            }
            else
            {
                Console.WriteLine("Both names are not equal");
            }
            if(name1 == name2)
            {
                Console.WriteLine("Both names are equal");
            }
            else
            {
                Console.WriteLine("Both names are not equal");
            }
        }
    }
}
