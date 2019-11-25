using System;
using System.Collections.Generic;
using System.Text;

namespace Algor.Search
{
    public static partial class Search
    {


        public static int BinarySearch(IList<int> pIList, int pItem)
        {
            int rLeft = 0;
            int rRight = pIList.Count - 1;

            if (rRight == 0)
            {
                return -1;
            }

            int rIndx;

            while (rLeft <= rRight)
            {
                rIndx = (rLeft + rRight) / 2;

                if (pIList[rIndx] == pItem)
                {
                    return rIndx;
                }
                
                if (pIList[rIndx] > pItem)
                {
                    // left side
                    rRight = rIndx - 1;
                }
                else
                {
                    // right side
                    rLeft = rIndx + 1;
                }
            }

            return -1;
        }

        public static bool BinarySearch(IList<int> pIList, int pItem, out int opIndx)
        {
            int rLeft = 0;
            int rRight = pIList.Count - 1;

            if (rRight == 0)
            {
                opIndx = 0;
                return false;
            }

            int rIndx = (rLeft + rRight) / 2;

            while (rLeft <= rRight)
            {
                rIndx = (rLeft + rRight) / 2;

                if (pIList[rIndx] == pItem)
                {
                    opIndx = rIndx;
                    return true;
                }

                if (pIList[rIndx] > pItem)
                {
                    // left side
                    rRight = rIndx - 1;
                }
                else
                {
                    // right side
                    rLeft = rIndx + 1;
                }

                
            }

            opIndx = rIndx;
            return false;
        }
    }
}
