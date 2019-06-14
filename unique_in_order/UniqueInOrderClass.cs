using System;
using System.Collections.Generic;

namespace unique_in_order
{
    public class UniqueInOrderClass
    {
        private string theString;

    
        public UniqueInOrderClass()
        {
            
        }
        public static char[] UniqueInOrder(string s)
        {
            List<string> outString = new List<string>();
            char[] sArray = s.ToCharArray();
            int k = sArray.Length;

            // outArray set to length of starting string because there could be no duplicates
            char[] outArray = new char[k]; 
            int j = 0;
            outArray[j] = sArray[0];
            for(int i = 1;i<sArray.Length;i++)
            {
                if(outArray[j] == sArray[i])
                {
                    i++;
                }
                else
                {
                    outArray[++j] = sArray[i];
                }
  
            }
            return outArray;
         
        }

    }
}
