using System;
using NUnit.Framework;

namespace bober753.fizBuz.test
{
    [TestFixture]
    class When_checking_user_input
    {
        [Test]
        public string Should_return_true()
        {

            string rawData ="6";
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
                toReturn = Should_return_true();
            }
            return toReturn;

        }

        [Test]
        public string Should_return_false()
        {

            string rawData = "g";
            string toReturn = string.Empty;
            foreach (char c in rawData)
            {
                if (Char.IsDigit(c))
                {
                    toReturn += c;
                }
            }

            if (toReturn == string.Empty)
            {
                toReturn = Should_return_false();
            }
            return toReturn;

        }

        public void Should_pass()
        {
            Assert.Pass();
        }
    }
}

    
    

