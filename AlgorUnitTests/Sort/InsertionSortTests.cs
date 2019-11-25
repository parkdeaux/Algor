using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algor.Sort;

namespace AlgorUnitTests
{
    [TestClass]
    public class InsertionSortTests
    {


        [TestMethod]
        public void tSimpleList()
        {
            IList<int> tList = new List<int>()
            {
                1, 3, 0, 5, 1, 4, 3, 100, 0
            };

            Sort.InsertionSort<int>(ref tList);

            List<int> tExpected = new List<int>()
            {
                0, 0, 1, 1, 3, 3, 4, 5, 100
            };

            CollectionAssert.AreEqual((List<int>)tList, tExpected);
        }
    }
}
