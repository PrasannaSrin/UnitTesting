using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleUnitTesting;

namespace SampleUnitTesting_Test
{
    [TestClass]
    public class UnitTestingScript
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            Assert.IsTrue((p.Add(1, 2) <= int.MaxValue));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Program p1 = new Program();
            Assert.IsTrue((p1.Add(1,2) < 0));
        }
    }
}
