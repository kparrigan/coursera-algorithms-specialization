using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxPairwiseProduct.Test
{
    [TestClass]
    public class MaxPairwiseProductTest
    {
        [TestMethod]
        public void CanProcessRandomInput()
        {
            var rand = new Random((int)System.DateTime.Now.Ticks);
            for(var x = 0; x < 100000; x++)
            {
                int n = rand.Next() % 10 + 2;
                Console.WriteLine(n);

                int[] numbers = new int[n];

                for (int i = 0; i < n; ++i)
                {
                    numbers[i] = rand.Next() % 100000;
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();

                var res1 = MaxPairwiseProduct.ComputeMaxPairwiseProduct(numbers);
                var res2 = MaxPairwiseProduct.ComputeMaxPairwiseProductFast(numbers);
                if (res1 != res2)
                {
                    Console.WriteLine($"Wrong answer: {res1} {res2}");
                    break;
                }
                else
                {
                    Console.WriteLine("OK");
                }
            }
        }

        [TestMethod]
        public void CanComputeFastPairwiseProduct()
        {
            var numbers = new int[1000000];
            var result = MaxPairwiseProduct.ComputeMaxPairwiseProductFast(numbers);
            Assert.AreEqual(0, result);

            numbers = new int[3] { 1, 2, 3 };
            result = MaxPairwiseProduct.ComputeMaxPairwiseProductFast(numbers);
            Assert.AreEqual(6, result);

            numbers = new int[3] { 7, 2, 5 };
            result = MaxPairwiseProduct.ComputeMaxPairwiseProductFast(numbers);
            Assert.AreEqual(35, result);

            numbers = new int[2] { 100000, 90000 };
            result = MaxPairwiseProduct.ComputeMaxPairwiseProductFast(numbers);
            Assert.AreEqual(9000000000, result);
        }
    }
}
