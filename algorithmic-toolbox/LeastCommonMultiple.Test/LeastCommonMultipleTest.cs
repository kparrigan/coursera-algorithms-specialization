using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeastCommonMultiple;

namespace LeastCommonMultiple.Test
{
    [TestClass]
    public class LeastCommonMultipleTest
    {
        [TestMethod]
        public void CanComputeLCM()
        {
            Assert.AreEqual(24, LCM.Compute(6, 8));
            Assert.AreEqual(1933053046, LCM.Compute(28851538, 1183019));
        }
    }
}
