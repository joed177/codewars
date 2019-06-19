using System;
using System.Collections.Generic;
using unique_in_order;

namespace OddInt
{
    public class OddNumberOfInts
    {
        public OddNumberOfInts() { }
        const int COUNT_POSITION = 1;
        const int VALUE_POSITION = 0;
        const int COLUMNS = 2;

        public static int[,] CountInts(int[]inputInts)
        {
            int initialCount = 1;
            Array.Sort(inputInts);
            int j = 0;
            int[,] outArray = new int[inputInts.Length,COLUMNS];
            outArray[0, 0] = inputInts[j];
            outArray[0, 1] = initialCount;
            for(int i=1;i<inputInts.Length;i++)
            {
                if (inputInts[i] == outArray[j, VALUE_POSITION])
                    outArray[j, COUNT_POSITION]++;
                else
                {
                    j++;
                    outArray[j, VALUE_POSITION] = inputInts[i];
                    outArray[j, COUNT_POSITION] = initialCount;

                }
             
            }
            return outArray;

        }

        public static int OddInt(int[] inArray)
        {
            int[,] outArray = new int[inArray.Length, COLUMNS];
            int even = 2;
            outArray = OddNumberOfInts.CountInts(inArray);
            for(int i=0;i<inArray.GetLength(VALUE_POSITION);i++)
            {
                outArray[i, COUNT_POSITION] = outArray[i, COUNT_POSITION] % even;
            }
            for(int i=0;i<inArray.GetLength(VALUE_POSITION);i++)
            {
                if (outArray[i, COUNT_POSITION] > 0)
                    return outArray[i, VALUE_POSITION];
            }
            return -1;
        }

    }
}
