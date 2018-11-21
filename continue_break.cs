using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if ( number < 0 )
                {
                    continue; // continue to the next for 
                }

                if ( number == 0 )
                {
                    break; // get out of the for [terminate]
                }

                sum = sum + number;
            }

            Console.WriteLine( sum );

        }
    }
}
