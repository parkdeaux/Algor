using System;
using System.Collections.Generic;
using System.Text;

namespace Algor.Sort
{
    public static partial class Sort
    {
        public static void BubbleSort<T>(ref IList<T> pIList) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            bool rSwap = true;

            while(rSwap)
            {
                rSwap = false;

                for (int i = 0; i < pIList.Count-1; i++)
                {
                    if (pIList[i].CompareTo(pIList[i+1]) > 0)
                    {
                        _swap(ref pIList, i, i + 1);
                        rSwap = true;
                    }
                }
            }
        }
    }
}
