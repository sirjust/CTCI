using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// replace all spaces in a string with %20

namespace p90_URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(URLify("Hello my name is Justin."));
            Console.Read();
        }

        public static string URLify(string input)
        {
            input = input.TrimEnd(' ');
            char[] inputArray = input.ToCharArray();
            char[] output = new char[0];
            for (int i = 0; i< inputArray.Length; i++)
            {
                if (inputArray[i]== ' ')
                {
                    Array.Resize(ref output, output.Length + 3);
                    output[output.Length - 3] = '%';
                    output[output.Length - 2] = '2';
                    output[output.Length - 1] = '0';
                }
                else
                {
                    Array.Resize(ref output, output.Length + 1);
                    output[output.Length - 1] = inputArray[i];
                }
            }
            string finalString = string.Join("", output);
            return finalString;
        }
    }
}
