using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringRotation
{
    public class StringRotation
    {
        public bool MySolution(string original, string itemToBeChecked)
        {
            if (original.Length != itemToBeChecked.Length)
            {
                return false;
            }

            if (original == itemToBeChecked)
            {
                return true;
            }

            var firstLetter = original[0];
            // this will throw an exception if there isn't a corresponding index
            var correspondingIndex = itemToBeChecked.IndexOf(firstLetter);
            var j = 0;
            for (var i = correspondingIndex; i < itemToBeChecked.Length; i++)
            {
                if (itemToBeChecked[i] != original[j])
                {
                    return false;
                }

                j++;
            }
            return IsSubString(original, itemToBeChecked.Remove(correspondingIndex));
        }

        public bool IsSubString(string firstString, string stringToBeChecked)
        {
            if (firstString == null || stringToBeChecked == null)
            {
                return false;
            }
            var firstLetter = stringToBeChecked[0];
            var correspondingIndex = firstString.IndexOf(firstLetter);
            var j = 0;
            for (int i = correspondingIndex; i<stringToBeChecked.Length; i++)
            {
                if (firstString[i] != stringToBeChecked[j])
                {
                    return false;
                }
                j++;
            }
            return true;
        }

        public bool BookSolution(string s1, string s2)
        {
            var len = s1.Length;
            // check the two strings are equal in length
            if (len != s2.Length || len <= 0) return false;
            // concatenate s1 and s1 within new buffer
            var s1s1 = s1 + s1;
            return IsSubString(s1s1, s2);
        }
    }
}
