using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Program
    {
        public static string[] movies = {"Men in black", "Star Wars", "Untouchables"};

        public static void start()
        {
            string input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "one":
                case "1":
                    Console.WriteLine("{0}, {1}, {2}", movies);
                    Console.ReadKey();
                    break;
                case "quit":
                case "Quit":
                    break;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the movie library.");
            Console.WriteLine();
            Console.WriteLine("Press one to show movies.");
            Console.WriteLine("Type quit to exit.");
        
            start();



        }

        //public static string inputIsOne()
        //{
        //    movies = "Men In Black" ;
          
        //    return movies;
        //}
       
    }
}