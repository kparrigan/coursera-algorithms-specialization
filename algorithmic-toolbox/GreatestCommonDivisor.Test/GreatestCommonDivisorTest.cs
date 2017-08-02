using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreatestCommonDivisor;

namespace GreatestCommonDivisor.Test
{
    [TestClass]
    public class GreatestCommonDivisorTest
    {
        [TestMethod]
        public void CanComputeGCD()
        {
            Assert.AreEqual(1, GCD.Compute(18,35));
            Assert.AreEqual(17657, GCD.Compute(28851538, 1183019));
        }
    }
}
