using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2111_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = Convert.ToInt32(Console.ReadLine()); // read a number

            // run from 1 -> rows
            for (int i = 1; i <= rows; i++)
            {

                // print all numbers from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); // print j do not line feed
                }

                Console.WriteLine(); // line feed
            }

            // run from rows -> 1
            for (int i = rows - 1; i >= 1; i--)
            {

                // print all numbers from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); // print j do not line feed
                }

                Console.WriteLine(); // line feed
            }
        }
    }
}
