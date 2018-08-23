using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euclid;

namespace EuclidTests
{
    [TestClass]
    public class EuclidAlgorithmTests
    {
        [TestMethod]
        public void GreatestCommonDivisor_PositiveSmallPrimes_Returns1()
        {
            int a = 5;
            int b = 3;

            int actual = EuclidAlgorithm.GreatestCommonDivisor(a, b);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
