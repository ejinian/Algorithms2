using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 1, 16, 4, 8 };
            Searcher mySearcher = new Searcher();

            //int myResult = mySearcher.Find(numbers, 10);
            //int largestNumber = mySearcher.LargestNumberFinder(numbers);

            //int secondLargestNumber = mySearcher.SecondLargestNumberFinder(numbers);

            /*
            int[] nums = new int[] { 2, 11, 14, 17 };
            int target = 16;
            
            LeetCodeProgram1 myClass = new LeetCodeProgram1();
            int [] result = myClass.TwoSum(nums, target);
            result.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Console.ReadLine();
            */

            int x = 2147483647;

            LeetCodeProgram2 myClass2 = new LeetCodeProgram2();
            int reversed = myClass2.Reverse(x);

            Console.WriteLine(reversed);
            Console.ReadLine();
        }
    }
}

class LeetCodeProgram1
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { -1 };
    }
}

class LeetCodeProgram2
{
    public int Reverse(int x)
    {
        int changeNumber;
        int reversed = 0;
        if (x > 2147483647)
        {
            return 0;
        }
        while (x != 0)
        {
            changeNumber = x % 10;
            reversed = reversed * 10 + changeNumber;
            x = x / 10;
        }
        if (reversed < 0)
        {
            return 0;
        }
        return reversed;
    }
}