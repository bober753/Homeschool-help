using NUnit.Framework;
using bober753.fizBuz.core;

namespace bober753.fizBuz.test
{
    [TestFixture]
    internal class WhenUsingFizBuzNumberParser
    {
        [Test]
        public void should_pass()
        {
            Assert.Pass();
        }

        [Test]
        public void giveing_number_one_and_expecting_the_number_one_back()
        {
            FizBuzParser fizBuzParser = new FizBuzParser();

            string result = fizBuzParser.GetResult(1);

            Assert.AreEqual("1", result);
        }

        [Test]
        public void giveing_the_number_three_to_FizBuzParser_and_expecting_fiz()
        {
            FizBuzParser fizBuzParser = new FizBuzParser();

            string result = fizBuzParser.GetResult(3);

            Assert.AreEqual("fiz", result);
        }

        [Test]
        public void giveing_the_number_five_and_expecting_buz()
        {
            FizBuzParser fizBuzParser = new FizBuzParser();

            string result = fizBuzParser.GetResult(5);

            Assert.AreEqual("buz", result);
        }

        [Test]
        public void giveing_the_number_six_to_FizBuzParser_and_expecting_fiz()
        {
            FizBuzParser fizBuzParser = new FizBuzParser();

            string result = fizBuzParser.GetResult(6);

            Assert.AreEqual("fiz", result);
        }

        [Test]
        public void giveing_the_number_ten_and_expecting_buz()
        {
            FizBuzParser fizBuzParser = new FizBuzParser();

            string result = fizBuzParser.GetResult(10);

            Assert.AreEqual("buz", result);
        }

        [Test]
        public void giveing_the_number_fifteen_to_FizBuzParser_and_expecting_fizbuz()
        {
            FizBuzParser fizBuzParser = new FizBuzParser();

            string result = fizBuzParser.GetResult(15);

            Assert.AreEqual("fizbuz", result);
        }
    }

    
}
