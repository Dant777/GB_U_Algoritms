using Lesson_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lesson_1_Tests
{
    [TestClass]
    public class Task_1_Test
    {
        SimpleNumber simpleNumber;
        [TestInitialize]
        public void TestInitialize()
        {
            simpleNumber = new SimpleNumber();
        }

        [TestMethod]
        public void CheckSimpleNumber_3_trueReturned()
        {

            int number = 3;
            bool expected = true;

            bool actual =  simpleNumber.CheckNumber(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckSimpleNumber_4_falseReturned()
        {

            int number = 4;
            bool expected = false;

            bool actual = simpleNumber.CheckNumber(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckSimpleNumber_7_trueReturned()
        {

            int number = 7;
            bool expected = true;

            bool actual = simpleNumber.CheckNumber(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckSimpleNumber_28_falseReturned()
        {

            int number = 28;
            bool expected = false;

            bool actual = simpleNumber.CheckNumber(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckSimpleNumber_67_trueReturned()
        {

            int number = 67;
            bool expected = true;

            bool actual = simpleNumber.CheckNumber(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
