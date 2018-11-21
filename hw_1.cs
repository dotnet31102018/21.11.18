using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2111_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int m1 = 0; // we use m1 as zero [like x1] to match the while condition (x1 == m1)
            int x1 = 0; // we use x1 as zero [like z1] to match the while condition (x1 == m1)

            while (x1 == m1)
            {

                // =========================== Copied from GIT 
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
                }
                else
                {
                    Console.WriteLine("Lo Rishoni!");
                }
                // ================================================
            }
        }
    }
}
