using System;
using System.Collections.Generic;

namespace Algor.Sort
{
    public static partial class Sort
    {

        private static void _swap<T> (ref IList<T> pIList, int i, int j) where T : struct
        {
            T rTemp = pIList[i];
            pIList[i] = pIList[j];
            pIList[j] = rTemp;
        }
        public static void InsertionSort<T> (ref IList<T> pIList) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            // compare element with sorted elements behind it
            for (int i = pIList.Count - 1; i >= 0; i--)
            {
                // element to place in sorted end of array with indices < i
                T sForward = pIList[i];

                // sorted tail elements
                int k = i;
                for (int j = i + 1; j < pIList.Count; j++)
                {
                    // current sorted tail element
                    T sBehind = pIList[j];

                    
                    // if sForward > sBehind move 
                    if (sForward.CompareTo(sBehind) > 0)
                    {
                        _swap(ref pIList, k, j);
                        k++;
                    }
                    // element is in correct position
                    else
                    {
                        break;
                    }
                    
                }
            }
        }
    }
}
