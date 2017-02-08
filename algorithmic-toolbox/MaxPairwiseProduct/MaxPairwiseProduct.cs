using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPairwiseProduct
{
    public class MaxPairwiseProduct
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            var numbers = new int[n];

            for(int i = 0, len = numbers.Length; i < len; i++)
            {
                numbers[i] = int.Parse(tokens[i]);
            }

            var result = ComputeMaxPairwiseProductFast(numbers);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static long ComputeMaxPairwiseProduct(int[] numbers)
        {
            long result = 0;
            var len = numbers.Length;

            for (var i = 0; i < len; ++i)
            {
                for (var j = i + 1; j < len; ++j)
                {
                    var temp = (long)numbers[i] * (long)numbers[j];
                    if (temp > result)
                    {
                        result = temp;
                    }
                }
            }

            return result;
        }

        public static long ComputeMaxPairwiseProductFast(int[] numbers)
        {
            var n = numbers.Length;

            int max_index1 = -1;
            for(var i = 0; i < n; ++i)
            {
                if ((max_index1 == -1) || (numbers[i] > numbers[max_index1]))
                {
                    max_index1 = i;
                }
            }

            var max_index2 = -1;
            for (var j = 0; j < n; ++j)
            {
                if ((j != max_index1) && ((max_index2 == -1) || (numbers[j] > numbers[max_index2])))
                {
                    max_index2 = j;
                }
            }

            return (long)numbers[max_index1] * (long)numbers[max_index2];
        }
    }
}
