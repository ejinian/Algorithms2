using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Searcher
    {
        public int Find(int[] numbers, int number) //time complexity is O(n)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int numberFromArray = numbers[i];
                if (numberFromArray == number)
                {
                    return i;
                }
            }
            return -1;
        }
        
        public int LargestNumberFinder(int[] numbers) //time complexity is O(n)
        {
            int largestNumberSoFar = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largestNumberSoFar)
                {
                    largestNumberSoFar = numbers[i];
                }
            }
            return largestNumberSoFar;
        }

        public int SecondLargestNumberFinder(int[] numbers)
        {
            int first, second;
            first = second = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > first)
                {
                    second = first;
                    first = numbers[i];
                }
                else if (numbers[i] > second && numbers[i] != first)
                {
                    second = numbers[i];
                }
            }
            if (second == int.MinValue)
            {
                return -1;
            }
            else
            {
                return second;
            }
        }
    }
}
