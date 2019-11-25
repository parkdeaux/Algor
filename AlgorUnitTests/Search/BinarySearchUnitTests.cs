using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algor.Search;

namespace AlgorUnitTests
{
    [TestClass]
    public class BinarySearchUnitTests
    {
        private readonly IList<int> tList = new List<int>()
            {
                0, 1, 2, 3, 5, 6
            };

        [TestMethod]
        public void tElementExists()
        {
            int tElement = 5;

            int tElementIndx = 4;
            int tIndx = Search.BinarySearch(tList, tElement);
            
            Assert.AreEqual(tIndx, tElementIndx);
        }

        [TestMethod]
        public void tElementDoesNotExist()
        {
            int tElement = 4;

            Assert.AreEqual(Search.BinarySearch(tList, tElement), -1);
        }

        [TestMethod]
        public void tElementEndOfList()
        {
            int tElement = 7;

            Assert.AreEqual(Search.BinarySearch(tList, tElement), -1);
        }


        [TestMethod]
        public void tElementEndOfList2()
        {
            int tElement = 7;

            int opIndx;
            bool tFound = Search.BinarySearch(tList, tElement, out opIndx);

            Assert.IsFalse(tFound);
            Assert.AreEqual(opIndx, 5);
        }


        [TestMethod]
        public void tElementExists2()
        {
            int tElement = 5;

            int tElementIndx = 4;
            int opIndx;
            bool tFound = Search.BinarySearch(tList, tElement, out opIndx);

            Assert.IsTrue(tFound);
            Assert.AreEqual(opIndx, tElementIndx);
        }

        [TestMethod]
        public void tElementDoesNotExist2()
        {
            int tElement = 4;
            int opIndx;
            bool tFound = Search.BinarySearch(tList, tElement, out opIndx);

            Assert.IsFalse(tFound);
            Assert.AreEqual(opIndx, 3);
        }
    }
}
