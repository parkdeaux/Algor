using System;
using System.Collections.Generic;
using System.Text;
using Algor.Search;
using Algor.Sort;

namespace Algor.Mixed
{
    public static partial class Mixed
    {
        public static void BSearchInsertion(ref IList<int> pIList, int pVal)
        {
            // do a binary search for where it would be inserted in list
            int opIndx;
            Search.Search.BinarySearch(pIList, pVal, out opIndx);

            // check if pIList[opIndx] < pVal;
            if (pIList[opIndx] < pVal)
            {
                opIndx++;
            }

            // if it should be inserted at end, add it to the end
            if (opIndx == pIList.Count)
            {
                pIList.Add(pVal);
            }
            // move everything in front up one position
            else
            {
                pIList.Add(pIList[pIList.Count - 1]);
                // starting from back, pull everything forward
                for (int i = pIList.Count-1; i > opIndx; i--)
                {
                    pIList[i] = pIList[i - 1];
                }

                pIList[opIndx] = pVal;
            }
            
        }
    }
}
