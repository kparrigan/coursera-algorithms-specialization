using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Test
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void CanComputeRecursive()
        {
            Assert.AreEqual(0, Fibonacci.ComputeRecursive(0));
            Assert.AreEqual(1, Fibonacci.ComputeRecursive(1));
            Assert.AreEqual(2, Fibonacci.ComputeRecursive(3));
            Assert.AreEqual(55, Fibonacci.ComputeRecursive(10));
            Assert.AreEqual(267914296, Fibonacci.ComputeRecursive(42));
        }

        [TestMethod]
        public void CanComputeTable()
        {
            Assert.AreEqual(0, Fibonacci.ComputeTable(0));
            Assert.AreEqual(1, Fibonacci.ComputeTable(1));
            Assert.AreEqual(2, Fibonacci.ComputeTable(3));
            Assert.AreEqual(55, Fibonacci.ComputeTable(10));
            Assert.AreEqual(267914296, Fibonacci.ComputeTable(42));
        }

        [TestMethod]
        public void CanComputeLastDigit()
        {
            Assert.AreEqual(0, FibonacciLastDigit.ComputeLastDigit(0));
            Assert.AreEqual(1, FibonacciLastDigit.ComputeLastDigit(1));
            Assert.AreEqual(2, FibonacciLastDigit.ComputeLastDigit(3));
            Assert.AreEqual(9, FibonacciLastDigit.ComputeLastDigit(331));
            Assert.AreEqual(5, FibonacciLastDigit.ComputeLastDigit(327305));
        }
    }
}
