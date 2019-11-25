using Algor.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorUnitTests
{
    [TestClass]
    public class ShellSortTests
    {


        [TestMethod]
        public void tSimpleList()
        {
            IList<int> tList = new List<int>()
            {
                1, 3, 0, 5, 1, 4, 3, 100, 0
            };

            Sort.ShellSort<int>(ref tList);

            List<int> tExpected = new List<int>()
            {
                0, 0, 1, 1, 3, 3, 4, 5, 100
            };

            CollectionAssert.AreEqual((List<int>)tList, tExpected);
        }
    }
}
