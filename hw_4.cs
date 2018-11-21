using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2111
{
    class Program
    {
        static void Main(string[] args)
        {
            int stars = Convert.ToInt32(Console.ReadLine()); // read a number

            int i = 1; // number of starts i am drawing in the current row

            int spaces = stars / 2; // number of spaces in each row

            while (i <= stars)
            {
                // draw the spaces
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(' ');
                }

                // draw the stars
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();

                // add 2 to i
                i = i + 2;

                // decrease 1 to spaces
                spaces = spaces - 1;
            }
        }
    }
}
