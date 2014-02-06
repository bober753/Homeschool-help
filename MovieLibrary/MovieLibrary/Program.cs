using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Program
    {
        public static string movies;

        public static void start()
        {
            string input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "one":
                case "1":
                    inputIsOne();
                    Console.WriteLine(movies);
                    break;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the movie library.");
            Console.WriteLine();
            Console.WriteLine("Press one to show movies.");
        
            start();

            Console.ReadKey();

        }

        public static string inputIsOne()
        {
            movies = "Men In Black";
          
            return movies;
        }
       
    }
}
