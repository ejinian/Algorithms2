using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 1, 16, 4, 8 };
            Searcher mySearcher = new Searcher();

            //int myResult = mySearcher.Find(numbers, 10);
            //int largestNumber = mySearcher.LargestNumberFinder(numbers);
            //int secondLargestNumber = mySearcher.SecondLargestNumberFinder(numbers);
            //Console.WriteLine(ReverseString("Arthur"));
            //Console.WriteLine(RemoveAllSpaces("We will remove all spaces from this sentence"));
            //Console.WriteLine(SubstringMaker("Arthur", 1, 10));
            //Console.WriteLine(HammingDistanceCalculator("karolin", "kathrin"));
            //Console.WriteLine(PalindromeChecker("race car"));
            //Console.WriteLine(FibonacciDistance(5));
            //int[] arrayParams = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(ArrayIndexIdentifier(arrayParams, 1));
            //int[] result = ArraySorter(new int[] { 0, 3, 4, 6, 2, 9, 7, 13, 15 });
            //Console.WriteLine(ArraySorter(new int[] {0, 3, 4, 6, 2, 9, 7, 13, 15}));
            //Console.WriteLine(DelimiterChecker(("[[[]]")));
            //int[] toSearch = new int[] {0, 1, 9, 3, 4, 7};
            //Console.WriteLine(RomanToInt(("III")));
            Console.WriteLine();
            Console.ReadLine();
        }
        public static string ReverseString(string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result = result + s[i];
            }
            return result;
        }

        public static string RemoveAllSpaces(string s)
        {
            string cleaned = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() != " ")
                {
                    cleaned = cleaned + s[i];
                }
            }
            return cleaned;
        }

        public static string SubstringMaker(string s, int StartIndex, int Length)
        {
            string substringed = "";
            if (StartIndex + Length > s.Length)
            {
                return "error";
            }
            for (int i = StartIndex; i <= StartIndex + Length; i++)
            {
                substringed = substringed + s[i];
            }
            return substringed;
        }

        public static int HammingDistanceCalculator(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return -1;
            }
            int hammingValue = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != word2[i])
                {
                    hammingValue++;
                }
            }
            return hammingValue;
        }

        public static bool PalindromeChecker(string s)
        {
            string reversed = ReverseString(s);
            string cleaned = RemoveAllSpaces(s);
            string reversedAndCleaned = RemoveAllSpaces(reversed);
            int hammingDistanceForReversedAndCleaned = HammingDistanceCalculator(cleaned, reversedAndCleaned);
            return hammingDistanceForReversedAndCleaned == 0;
        }

        public static int FibonacciDistance(int distance)
        {
            if (distance < 2)
            {
                return 1;
            }
            return FibonacciDistance(distance - 1) + FibonacciDistance(distance - 2);
        }

        public static int ArrayIndexIdentifier(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int[] ArraySorter(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public static bool DelimiterChecker(string brackets)
        {
            int ifIsZero = 0;
            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i].ToString() == "[")
                {
                    ifIsZero++;
                }
                else if (brackets[i].ToString() == "]")
                {
                    ifIsZero--;
                }
            }
            return ifIsZero == 0;
        }

        public static int RomanToInt(string s)
        {
            Dictionary<string, int> romanToDecimalDict = new Dictionary<string, int>();
            romanToDecimalDict.Add("I", 1);
            romanToDecimalDict.Add("II", 2);
            romanToDecimalDict.Add("III", 3);
            romanToDecimalDict.Add("IV", 4);
            romanToDecimalDict.Add("V", 5);
            romanToDecimalDict.Add("X", 10);
            romanToDecimalDict.Add("L", 50);
            romanToDecimalDict.Add("C", 100);
            romanToDecimalDict.Add("D", 500);
            romanToDecimalDict.Add("M", 1000);
            int value = 0;
            if (romanToDecimalDict.TryGetValue("I", out value))
            {
                if (value.ToString() == s)
                {
                    return value;
                }
            }
            return value;
        }
    }
}
