using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_3;

namespace Lesson_1_Tests
{
    [TestClass]
    public class Task_3_Test
    {
     
        [TestMethod]
        public void RecursionFibonacci_4_3Returned()
        {
            int nubmer = 4;
            int expected = 3;

            int actual = FibonacciNumber.RecursionFibonacci(nubmer);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RecursionFibonacci_10_55Returned()
        {
            int nubmer = 10;
            int expected = 55;

            int actual = FibonacciNumber.RecursionFibonacci(nubmer);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NoRecursionFibonacci_4_3Returned()
        {
            int nubmer = 4;
            int expected = 3;

            int actual = FibonacciNumber.NoRecursionFibonacci(nubmer);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NoRecursionFibonacci_10_55Returned()
        {
            int nubmer = 10;
            int expected = 55;

            int actual = FibonacciNumber.NoRecursionFibonacci(nubmer);

            Assert.AreEqual(expected, actual);
        }
    }
}
