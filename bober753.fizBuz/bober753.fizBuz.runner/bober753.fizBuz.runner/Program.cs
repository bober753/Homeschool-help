using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bober753.fizBuz.core;

namespace bober753.fizBuz.runner
{
    class Program
    {
        static public int firstNumber;
        static public int secondNumber;
        static void Main(string[] args)
        {
            BringingInTakingUserInput();

            Console.ReadKey();
        }

        static public void BringingInTakingUserInput()
        {
            Console.WriteLine("Please slect a number.");
            firstNumber = UserInput.GetNumber();

            Console.WriteLine("Please select another number.");
            secondNumber = UserInput.GetNumber();

            Console.Clear();
            FizBuzProseser();
            
        }

        static public void FizBuzProseser()
        {
            FizBuzParser fizBuzParser = new FizBuzParser();

            TakingUserInput takingUserInput = new TakingUserInput(firstNumber, secondNumber);

            if (takingUserInput.secondNumberIsHigher)
            {
                for (int i = 1; firstNumber <= secondNumber; firstNumber++)
                {
                    Console.WriteLine(fizBuzParser.GetResult(firstNumber));
                }
            }

            else
            {
                Console.WriteLine("That is not valid input.");
                Console.WriteLine("The first number must be lower than the second.");
                BringingInTakingUserInput();
            }


        }
    }

    class UserInput
    {
        private static string GetInput()
        {
            string rawData = Console.ReadLine();
            string toReturn = string.Empty;
            foreach (char c in rawData)
            {
                if (Char.IsDigit(c))
                {
                    toReturn+= c;
                }
            }

            if (toReturn == string.Empty)
            {
                toReturn = GetInput();
            }
            return toReturn;
        }

        public static int GetNumber()
        {
            
            return Convert.ToInt32(GetInput());

        }
    }
}
