using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Searching
    {
        public static int BinarySearch(int[] numbers, int number)
        {
            int low = 0;
            int high = numbers.Length - 1;
            int mid = (low + high) / 2;

            while ((low != mid) && (mid != high) && (low != high))
            {
                if (number < numbers[mid])
                {
                    high = mid;
                    mid = (low + high) / 2;
                }
                else if (number > numbers[mid])
                {
                    low = mid;
                    mid = (low + high) / 2;
                }

                if (number == numbers[mid])
                {
                    return mid;
                }
            }

            // Number does not exists
            return -1;
        }

    }
}
