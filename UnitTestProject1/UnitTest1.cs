using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void endPointsTest1()
        {
            int[] range = { 2, 6 };
            string result = "";
            Assert.AreEqual("[2,6) endPoints = {2,5}", result);
        }
        [TestMethod]
        public void endPointsTest2()
        {
            int[] range = { 2, 6 };
            string result = "";
            Assert.AreEqual("[2,6] endPoints = {2,6}", result);
        }
        [TestMethod]
        public void endPointsTest3()
        {
            int[] range = { 2, 6 };
            string result = "";
            Assert.AreEqual("(2,6) endPoints = {3,5}", result);
        }
        [TestMethod]
        public void endPointsTest4()
        {
            int[] range = { 2, 6 };
            string result = "";
            Assert.AreEqual("(2,6] endPoints = {3,6}", result);
        }

    }
}
