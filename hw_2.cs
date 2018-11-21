using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2111_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = Convert.ToInt32(Console.ReadLine()); // read a number

            // how much 100 classes ?
            int class100 = students / 100;

            // how much left?
            students = students - (class100 * 100); // numbers of students - (how_many_classes_of_100 * 100 students)

            // how much 30 classes ?
            int class30 = students / 30;

            // how much left?
            students = students - (class30 * 30); // numbers of students - (how_many_classes_of_30 * 30 students)

            // how much 10 classes ?
            int class10 = students / 10;

            // how much left?
            students = students - (class10 * 10); // numbers of students - (how_many_classes_of_10 * 10 students)

            Console.WriteLine("class 100 " + class100);
            Console.WriteLine("class 30 "  + class30);
            Console.WriteLine("class 10 "  + class10);
            Console.WriteLine("Going home " + students);

        }
    }
}
