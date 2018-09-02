using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// checks if a string is a permutation of a palindrome

namespace p91_palindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPermutation("hello"));
            Console.WriteLine(isPermutation("1221"));
            Console.WriteLine(isPermutation("rats live on no evil star"));
            Console.WriteLine(isPermutation("palindrome"));
            Console.WriteLine(isPermutation("12:21"));
            Console.WriteLine(isPermutation("123456654321"));
            Console.WriteLine(isPermutation("hhheelloooo"));
            Console.Read();
        }

        static bool isPermutation(string input)
        {
            input = input.Trim(' ').ToLower();
            char[] inputArray = input.ToCharArray();
            Array.Sort(inputArray);
            bool isPermutation = true;
            if (inputArray.Length % 2 == 0)
            {
                for(int i = 0; i <= inputArray.Length - 2; i += 2)
                {
                    if (!(inputArray[i] == inputArray[i + 1]))
                    {
                        isPermutation = false;
                        break;
                    }
                    else continue;
                }
            }
            else
            {
                int numberOfMismatches = 0;
                bool lastOneTrue = false;
                for (int i = 0; i < inputArray.Length-1; i++)
                {
                    if (numberOfMismatches > 1)
                    {
                        isPermutation = false;
                        break;
                    }
                    if (lastOneTrue)
                    {
                        lastOneTrue = false;
                        continue;
                    }

                    if (inputArray[i] == inputArray[i + 1])
                    {
                        lastOneTrue = true;
                        continue;
                    }
                    else
                    {
                        numberOfMismatches += 1;
                        continue;
                    }
                }
            }
            return isPermutation;
        }
    }
}
