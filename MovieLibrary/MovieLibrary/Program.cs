using System;

namespace MovieLibrary
{
    class Program
    {
        public string input;

        public bool closeTheProgram = false;

        public string[] Movies = {"Men in black", "Star Wars", "Untouchables"};

        public void start()
        {
            input == Console.ReadLine();

            Console.Clear();
            
            switch (input)
            {
                case "one":
                case "1":
                    {
                        foreach (string movies in Movies)
                        {
                            Console.WriteLine(movies);
                        }
                        break;
                    }
            }
        }

        public void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nathans' movie library");
            do
            {
                Console.WriteLine("Press one to show movies.");
                Console.WriteLine("Type quit to exit.");
                
                start();

                if(input == "Quit" || input == "quit")
                {
                    closeTheProgram = true;
                }
            } while (closeTheProgram == false);
        }
    }
}