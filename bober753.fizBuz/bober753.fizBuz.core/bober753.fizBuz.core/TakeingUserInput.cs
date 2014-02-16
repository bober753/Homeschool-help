using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bober753.fizBuz.core
{
    public class TakingUserInput
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public bool secondNumberIsHigher;

        public TakingUserInput(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            if (firstNumber < secondNumber)
            {
                secondNumberIsHigher = true;
            }
            else
            {
                secondNumberIsHigher = false;
            }
        }
    }
}
