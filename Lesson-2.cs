using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class unary
    {
        static void Main()
        {
            bool content = true;
            bool noContent = false;

            Console.WriteLine("It is {0} that C# Station provides C# programming language content.", content);
            Console.WriteLine("The statement above is not {0}.", noContent);
            Console.WriteLine(" ");
            //Console.ReadKey();

            int unary = 0;
            int preIncrement;
            int preDecrement;
            int postIncrement;
            int postDecrement;
            int positive;
            int negative;
            sbyte bitNot;
            bool logNot;

            preIncrement = ++unary;
            Console.WriteLine("pre-Increment: {0}", preIncrement);

            preDecrement = --unary;
            Console.WriteLine("pre-Decrement: {0}", preDecrement);

            postDecrement = unary--;
            Console.WriteLine("Post-Decrement: {0}", postDecrement);

            postIncrement = unary++;
            Console.WriteLine("Post-Increment: {0}", postIncrement);

            Console.WriteLine("Final Value of Unary: {0}", unary);

            positive = -postIncrement;
            Console.WriteLine("Positive: {0}", positive);

            negative = +postIncrement;
            Console.WriteLine("Negative: {0}", negative);

            bitNot = 0;
            bitNot = (sbyte)(~bitNot);
            Console.WriteLine("Bitwise Not: {0}", bitNot);

            logNot = false;
            logNot = !logNot;
            Console.WriteLine("Logical Not: {0}", logNot);
            Console.WriteLine(" ");
            //Console.ReadKey();

            int x, y, result;
            float floatresult;

            x = 7;
            y = 5;

            result = x + y;
            Console.WriteLine("x+y: {0}", result);

            result = x - y;
            Console.WriteLine("x-y: {0}", result);

            result = x * y;
            Console.WriteLine("x*y: {0}", result);

            result = x / y;
            Console.WriteLine("x/y: {0}", result);

            floatresult = (float)x / (float)y;
            Console.WriteLine("x/y: {0}", floatresult);

            result = x % y;
            Console.WriteLine("x%y: {0}", result);

            result += x;
            Console.WriteLine("result+=x: {0}", result);
            Console.WriteLine(" ");
            //Console.ReadKey();

            int[] myInts = { 5, 10, 15 };
            bool[][] myBools = new bool[2][];
            myBools[0] = new bool[2];
            myBools[1] = new bool[1];
            double[,] myDoubles = new double[2, 2];
            string[] myStrings = new string[3];

            Console.WriteLine("myInts[0]: {0}, myInts[1]: {1}, myInts[2]: {2}", myInts[0], myInts[1], myInts[2]);

            myBools[0][0] = true;
            myBools[0][1] = false;
            myBools[1][0] = true;
            Console.WriteLine("myBools[0][0]: {0}, myBools[1][0]: {1}", myBools[0][0], myBools[1][0]);

            myDoubles[0, 0] = 3.147;
            myDoubles[0, 1] = 7.157;
            myDoubles[1, 1] = 2.117;
            myDoubles[1, 0] = 56.00138917;
            Console.WriteLine("myDoubles[0, 0]: {0}, myDoubles[1, 0]: {1}", myDoubles[0, 0], myDoubles[1, 0]);

            myStrings[0] = "Joe";
            myStrings[1] = "Matt";
            myStrings[2] = "Robert";
            Console.WriteLine("myStrings[0]: {0}, myStrings[1]: {1}, myStrings[2]: {2}", myStrings[0], myStrings[1], myStrings[2]);
            Console.ReadKey();


        }
    }
}
