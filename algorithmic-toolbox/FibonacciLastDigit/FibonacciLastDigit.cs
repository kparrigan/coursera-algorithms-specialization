using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciLastDigit
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = ComputeLastDigit(n);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        /// <summary>
        /// Computes the last digit of the nth Fibonacci number
        /// </summary>
        /// <param name="n">nth Fibonacci number to compute.</param>
        /// <returns>Last digit of nth Fibonacci number.</returns>
        public static int ComputeLastDigit(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("n");
            }

            if (n <= 1)
            {
                return n;
            }

            var fibs = new int[n + 1];
            fibs[0] = 0;
            fibs[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                fibs[i] = (fibs[i - 1] + fibs[i - 2]) % 10;
            }

            return fibs[n];
        }
    }
}
