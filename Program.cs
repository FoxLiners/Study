using System;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0, j = 0; i <= 15; i += 3, j += 5)
            {
                Console.WriteLine("i = " + i);
                Console.WriteLine("j = " + j);

                sum += i;

                Console.WriteLine("Sum after adding i  = " + sum);

                if (j < 995 && j % 3 != 0)
                {
                    sum += j;
                }

                Console.WriteLine("Sum after adding j  = " + sum);

            }
        
        }

    }
}
