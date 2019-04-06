using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRotation
{
    public class StringRotation
    {
        public bool stringRotation(string original, string itemToBeChecked)
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
    }
}
