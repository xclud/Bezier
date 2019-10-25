using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Geometry;

namespace System.Geometry_Test
{
    [TestClass]
    public class UtilsTest
    {
        [TestMethod]
        public void BetweenTest1()
        {
            bool result = Utils.approxBetween(1, 0, 2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void BetweenTest2()
        {
            bool result = Utils.approxBetween(0, 0, 2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void BetweenTest3()
        {
            bool result = Utils.approxBetween(2, 0, 2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void BetweenTest4()
        {
            bool result = Utils.approxBetween(-1, 0, 2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void BetweenTest5()
        {
            bool result = Utils.approxBetween(3, 0, 2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void BetweenTest6()
        {
            bool result = Utils.approxBetween(1, 0, 2);
            Assert.IsTrue(result);
        }


    }
}
