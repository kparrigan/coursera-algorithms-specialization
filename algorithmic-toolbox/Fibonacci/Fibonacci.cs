using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // instructions constrain 'n' to 0 <= n <= 45
            if (n < 0 || n > 45)
            {
                throw new ArgumentOutOfRangeException("n must be between 0 and 45 (inclusive)");
            }

            var result = ComputeTable(n);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        /// <summary>
        /// Computes the nth Fibonacci number recursively.
        /// </summary>
        /// <param name="n">nth Fibonacci number to compute.</param>
        /// <returns>nth Fibonacci number.</returns>
        public static long ComputeRecursive(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("n");
            }

            if (n <= 1)
            {
                return n;
            }

            return ComputeRecursive(n - 1) + ComputeRecursive(n - 2);
        }

        /// <summary>
        /// Computes the nth Fibonacci number using an array to store intermediate results.
        /// </summary>
        /// <param name="n">nth Fibonacci number to compute.</param>
        /// <returns>nth Fibonacci number.</returns>
        public static long ComputeTable(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("n");
            }

            if (n <= 1)
            {
                return n;
            }

            var fibs = new long[n + 1];
            fibs[0] = 0;
            fibs[1] = 1;

            for(var i = 2; i <= n; i++)
            {
                fibs[i] = fibs[i - 1] + fibs[i - 2];
            }

            return fibs[n];
        }
    }
}
