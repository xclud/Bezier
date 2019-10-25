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
            bool result = Utils.between(1, 0, 2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void BetweenTest2()
        {
            bool result = Utils.between(0, 0, 2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void BetweenTest3()
        {
            bool result = Utils.between(2, 0, 2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void BetweenTest4()
        {
            bool result = Utils.between(-1, 0, 2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void BetweenTest5()
        {
            bool result = Utils.between(3, 0, 2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void BetweenTest6()
        {
            bool result = Utils.between(1, 0, 2);
            Assert.IsTrue(result);
        }


    }
}
