using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double avg = 0;
            int x = 0;
            int counter = 0;
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                counter++;
                sum = sum + x;
            }
            while (x != 0);

            avg = sum / counter; // this is considering the zero
            avg = sum / (counter - 1); // this is NOT considering the zero

        }
    }
}
