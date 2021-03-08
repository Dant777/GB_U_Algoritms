using lesson_4_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson_4_Test
{
    [TestClass]
    public class Tree_2_Test
    {
        public MyBinaryTree testTree;
        [TestInitialize]
        public void InitializeData()
        {
            testTree = new MyBinaryTree();
            testTree.AddItem(50);
            testTree.AddItem(40);
            testTree.AddItem(10);
            testTree.AddItem(60);
            testTree.AddItem(70);
            testTree.AddItem(20);
            testTree.AddItem(30);
            testTree.AddItem(5);
            testTree.AddItem(15);
            testTree.AddItem(80);
        }
        [TestMethod]
        public void GetNodeByValue_SearchNodeValue40_FindNodeValue40()
        {
            
            int expectedSearchNumber = 40;

            TreeNode node = testTree.GetNodeByValue(expectedSearchNumber);

            int actual = node.Value;

            Assert.AreEqual(expectedSearchNumber, actual);
        }

        [TestMethod]
        public void GetNodeByValue_SearchNodeValue5_FindNodeValue5()
        {

            int expectedSearchNumber = 5;

            TreeNode node = testTree.GetNodeByValue(expectedSearchNumber);

            int actual = node.Value;

            Assert.AreEqual(expectedSearchNumber, actual);
        }

        [TestMethod]
        public void GetNodeByValue_SearchNodeValue80_FindNodeValue80()
        {

            int expectedSearchNumber = 80;

            TreeNode node = testTree.GetNodeByValue(expectedSearchNumber);

            int actual = node.Value;

            Assert.AreEqual(expectedSearchNumber, actual);
        }
    }
}
