using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Algor.Mixed;

namespace AlgorUnitTests
{
    [TestClass]
    public class BinarySearchInsertionSortUnitTest
    {
        private IList<int> tList = new List<int>()
            {
                0, 1, 2, 3, 5, 6
            };

        private IList<int> tListLower = new List<int>()
            {
                0, 1, 2, 3, 3, 6
            };

        [TestMethod]
        public void tEndOfList()
        {
            int tElement = 7;

            Mixed.BSearchInsertion(ref tList, tElement);

            List<int> tVal = new List<int>()
            {
                0, 1, 2, 3, 5, 6, 7
            };

            CollectionAssert.AreEqual((List<int>)tList, tVal);
        }

        [TestMethod]
        public void tGeneralHigher()
        {
            int tElement = 4;

            Mixed.BSearchInsertion(ref tList, tElement);

            List<int> tVal = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6
            };

            CollectionAssert.AreEqual((List<int>)tList, tVal);
        }


        [TestMethod]
        public void tGeneralLower()
        {
            int tElement = 4;

            Mixed.BSearchInsertion(ref tListLower, tElement);

            List<int> tVal = new List<int>()
            {
                0, 1, 2, 3, 3, 4, 6
            };

            CollectionAssert.AreEqual((List<int>)tListLower, tVal);
        }

        [TestMethod]
        public void tBeginningOfList()
        {
            int tElement = -1;

            Mixed.BSearchInsertion(ref tList, tElement);

            List<int> tVal = new List<int>()
            {
                -1, 0, 1, 2, 3, 5, 6
            };

            CollectionAssert.AreEqual((List<int>)tList, tVal);
        }
    }
}
