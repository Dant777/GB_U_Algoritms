using System;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree tree = new MyBinaryTree();
            tree.AddItem(50);
            tree.AddItem(40);
            tree.AddItem(10);
            tree.AddItem(60);
            tree.AddItem(70);
            tree.AddItem(20);
            tree.AddItem(30);
            tree.AddItem(5);
            tree.AddItem(15);
            tree.AddItem(80);

            tree.PrintTree();

            Console.WriteLine("----------BFS-----------");
            Console.WriteLine("BFS: " + tree.BFS());

            Console.WriteLine("----------DFS-----------");
            tree.DFS(tree.GetRoot());

            Console.ReadKey();
        }
    }
}
