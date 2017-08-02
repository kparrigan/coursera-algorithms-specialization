using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    public class GCD
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            var a = long.Parse(tokens[0]);
            var b = long.Parse(tokens[1]);

            var result = Compute(a, b);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static long Compute(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }

            return Compute(b, a % b);
        }
    }
}
