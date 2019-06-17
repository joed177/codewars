using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Isograms
{
    public class Isogram
    {
        public Isogram() { }

        public static bool isIsogram(string txtString)
        {
            try
            {
                if (containsNonAlpha(txtString.ToUpper()) || containsDuplicates(txtString.ToUpper()))
                    return false;
                return true;

            }
            catch (NotAWordException ex)
            {
                // do something
                return false;

            }
            catch (Exception ex)
            {
                // do something
                return false;

            }
            
         }

        private static bool containsNonAlpha(string txtString)
        {
            string pattern = "[^A-Z]+";
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(txtString) && (txtString != ""))
                return true;
            else return false;
        }

        private static bool containsDuplicates(string txtString)
        {
            List<char> inputList = convertStringToSortedList(txtString);
            for(int i=0; i< inputList.Count-1;i++)
            {
                if (inputList[i] == inputList[i + 1])
                    return true;
            }
            return false;
        }

        private static List<char> convertStringToSortedList(string txtString)
        {
            List<char> inputList = new List<char>();
            char[] txtArray = txtString.ToCharArray();
            foreach (char c in txtArray)
                inputList.Add(c);
            inputList.Sort();
            return inputList;

        }
    }
}
