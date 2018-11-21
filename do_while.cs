using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your option");
            Console.WriteLine("1. Say hello");
            Console.WriteLine("2. Say goodbye");
            Console.WriteLine("3. Dance");
            Console.WriteLine("4. Exit");

            int opt = 0;

            do
            {
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Hello !");
                        break;
                    case 2:
                        Console.WriteLine("Goodbye :(");
                        break;
                    case 3:
                        Console.WriteLine("I am dancing !!! :) Yeah!!");
                        break;
                    case 4:
                        Console.WriteLine("Sad to seew you leave");
                        break;
                    default:
                        Console.WriteLine("Wrong option.... ");
                        break;
                }
            }
            while (opt != 4);


        }
    }
}
