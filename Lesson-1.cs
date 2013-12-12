using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class NamedWelcomeNathan
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Station Tutorial");
            Console.WriteLine(" ");
            //Console.ReadKey();

            Console.WriteLine("Hello, {0}!", args[0]);
            Console.WriteLine("Welcome to the C# Station Tutorial");
            Console.WriteLine(" ");
            //Console.ReadKey();

            Console.WriteLine("what is your name?: ");
            Console.WriteLine("Hello, {0}!", Console.ReadLine());
            Console.WriteLine("Welcome to the C# Station Tutorial");
            Console.ReadKey();
        }
        
    }
}
