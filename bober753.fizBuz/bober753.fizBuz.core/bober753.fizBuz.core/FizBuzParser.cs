using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bober753.fizBuz.core
{
    public class FizBuzParser
    {
        public string GetResult(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "fizbuz";
            }

            if (i % 3 == 0)
            {
                return "fiz";
            }

            if (i % 5 == 0)
            {
                return "buz";
            }


            return i.ToString();
        }
    }
}
