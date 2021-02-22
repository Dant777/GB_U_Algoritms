using Lesson_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lesson_2_Tests
{
    [TestClass]
    public class Task_1_Test
    {
        LincedList list;

        [TestInitialize]
        public void InitializeData()
        {
            list = new LincedList();

            for (int i = 0; i < 10; i++)
            {
                list.AddNode(i);
            }
        }

        [TestMethod]
        public void AddNode_addOneNode_11CountReturned()
        {
            LincedList list_1 = list;

            list.AddNode(11);
            int expected = 11;

            int actual = list_1.GetCount();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNode_search3_nodeValue3Returned()
        {
            int searchNumber = 3;
            int expected = 3;

            Node actual = list.FindNode(searchNumber);

            Assert.AreEqual(expected, actual.Value);
        }

        [TestMethod]
        public void FindNode_search55_nullReturned()
        {
            int searchNumber = 55;
            Node expected = null;

            Node actual = list.FindNode(searchNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddNodeAfter_add777AfterNodeValue5_11CountReturned()
        {
            LincedList list_1 = list;
            int addNumber = 777;
            int nodeIndex = 5;
            int expectedCount = 11;
            int expectedValue = addNumber;

            list_1.AddNodeAfter(list_1.GetNode(nodeIndex), addNumber);
            int actualValue = list_1.GetNodeValue(6);
            int actualCount = list_1.GetCount();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void RemoveNode_RemoveNodeIndex5_9CountReturned()
        {
            LincedList list_1 = list;
            int nodeIndex = 5;
            int expectedCount = 9;

            list_1.RemoveNode(nodeIndex);
            int actualCount = list_1.GetCount();

            Assert.AreEqual(expectedCount, actualCount);

        }

        [TestMethod]
        public void RemoveNode_RemoveNode_9CountReturned()
        {
            LincedList list_1 = list;
            int nodeIndex = 5;
            int expectedCount = 9;
            Node removeNode = list_1.GetNode(nodeIndex);

            list_1.RemoveNode(removeNode);
            int actualCount = list_1.GetCount();

            Assert.AreEqual(expectedCount, actualCount);

        }
    }
}
