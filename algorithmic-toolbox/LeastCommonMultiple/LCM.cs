using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastCommonMultiple
{
    public class LCM
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            var a = int.Parse(tokens[0]);
            var b = int.Parse(tokens[1]);

            var result = Compute(a, b);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static long Compute(long a, long b)
        {
            var gcd = ComputeGCD(a, b);
            var ab = a * b;
            return ab / gcd;
        }

        /// <summary>
        /// Copying GCD here since the Grader requires 1 file. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long ComputeGCD(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }

            return ComputeGCD(b, a % b);
        }
    }
}
