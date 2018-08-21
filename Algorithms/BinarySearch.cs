using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class BinarySearch
    {
        public static int Rank(int key, int[] input)
        {
            // Assume array is sorted.
            int lo = 0;
            int hi = input.Length - 1;

            while(lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;

                if (key < input[mid]) hi = mid - 1;
                else if (key > input[mid]) lo = mid + 1;
                else return mid;
            }

            return -1;
        }
    }
}
