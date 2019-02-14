using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    public class Compress
    {
        public string CompressString(string input)
        {
            char[] inputArray = input.ToCharArray();
            if(inputArray.Length == 1 || inputArray.Length == 0)
            {
                return input;
            }
            List<char> compressedList = new List<char>();
            int consecutiveLetters = 1;
            for(int i = 1; i< inputArray.Length; i++)
            {
                if (i == inputArray.Length - 1)
                {
                    if (inputArray[i] == inputArray[i - 1])
                    {
                        consecutiveLetters++;
                    }
                    compressedList.Add(inputArray[i]);
                    if (consecutiveLetters > 9)
                    {
                        char[] numberArray = consecutiveLetters.ToString().ToCharArray();
                        foreach (char c in numberArray)
                        {
                            compressedList.Add(c);
                        }
                    }
                    else
                    {
                        compressedList.Add(Convert.ToChar(consecutiveLetters.ToString()));
                    }
                    break;
                }
                if (inputArray[i] == inputArray[i - 1])
                {
                    consecutiveLetters++;
                }
                else
                {
                    compressedList.Add(inputArray[i - 1]);
                    if (consecutiveLetters > 9)
                    {
                        char[] numberArray = consecutiveLetters.ToString().ToCharArray();
                        foreach(char c in numberArray)
                        {
                            compressedList.Add(c);
                        }
                    }
                    else
                    {
                        compressedList.Add(Convert.ToChar(consecutiveLetters.ToString()));
                    }
                    consecutiveLetters = 1;
                }
            }
            string myReturn = String.Join("", compressedList);
            return myReturn;
        }
    }
}
