using System;
using System.Collections.Generic;
using System.Text;

namespace Algor.Sort
{
    public static partial class Sort
    {
        public static void ShellSort<T>(ref IList<T> pIList) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            int rGap = pIList.Count / 2;

            while(rGap >= 1)
            {
                for (int i = rGap; i < pIList.Count; i++)
                {
                    
                    T sCurr = pIList[i];

                    int j;

                    for (j = i; j >= rGap; j-= rGap)
                    {
                        if (sCurr.CompareTo(pIList[j-rGap]) < 0)
                        {
                            pIList[j] = pIList[j - rGap];
                        }
                        else
                        {
                            break;
                        }
                    }

                    pIList[j] = sCurr;
                }

                rGap = rGap / 2;
            }
        }
    }
}
