using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;

namespace MyCalcLibTests
{
    [TestClass]
    public class MyCalcLibTests
    {
        [TestMethod]
        public void Sum10and20_30returned()
        {
            int x = 10;
            int y = 10;
            int expected = 20;
            MyCalc c = new MyCalc();
            int actial = c.Sum(x, y);
            Assert.AreEqual(expected, actial);

        }
        [TestMethod]
        public void Sum100and20_120returned()
        {
            int x = 100;
            int y = 20;
            int expected = 120;
            MyCalc c = new MyCalc();
            int actial = c.Sum(x, y);
            Assert.AreEqual(expected, actial);

        }
    }
}
