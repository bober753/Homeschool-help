using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class LessonOne
    {
        public static void Main(string[] args)
        {
            LessonOne LO = new LessonOne();

            Console.WriteLine("Would you like to test one or two?");

            string input = Console.ReadLine();

            if (input == "one")
                testOne();
            if (input == "two")
                testTwo();
            Console.ReadKey();
        }

        static void testOne()
        {
            

            Console.WriteLine("This is test number one!");
        }

        static void testTwo()
        {
            Console.WriteLine("This is test number two!");
        }
    }
}
