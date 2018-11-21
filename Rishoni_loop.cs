using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RishoniLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int x1, m1;
            int sum = 0;

            do
            {

                // =============== GIT CODE TO READ NUMBER AND CHECK IF PRIME OR NOT
                // 14.11.2018 78-92
                // first we test ourselves -can we find if number is prime ?
                m1 = 2;
                x1 = Convert.ToInt32(Console.ReadLine());
                while (x1 % m1 != 0 && m1 < x1)
                {
                    m1++;
                }
                if (x1 == m1)
                {
                    Console.WriteLine("Rishoni");
                    sum = sum + x1;
                }
                else
                {
                    Console.WriteLine("Lo Rishoni!");
                }
                // ===========================================================================

            }
            while (x1 == m1);

            Console.WriteLine( sum );

        }
    }
}
