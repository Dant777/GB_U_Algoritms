using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_2;

namespace Lesson_2_Tests
{
    [TestClass]
    public class Task_2_Test
    {
        public int[] intArr;
        [TestInitialize]
        public void InitializeData()
        {
            intArr = new int[100];

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = i;
            }
        }

        [TestMethod]
        public void BinarySearch_50_50returned()
        {
            int searchNumber = 50;
            int expected = 50;

            int actual = SearchClass.BinarySearch(intArr, searchNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BinarySearch_0_0returned()
        {
            int searchNumber = 0;
            int expected = 0;

            int actual = SearchClass.BinarySearch(intArr, searchNumber);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void BinarySearch_100_100returned()
        {
            int searchNumber = 0;
            int expected = 0;

            int actual = SearchClass.BinarySearch(intArr, searchNumber);

            Assert.AreEqual(expected, actual);
            
        }
     
    }
}
