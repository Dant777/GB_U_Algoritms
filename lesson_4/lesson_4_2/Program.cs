using System;
/*
  Реализуйте класс двоичного дерева поиска с операциями вставки, удаления, поиска. 
  Дерево должно быть сбалансированным (это требование не обязательно). 
  Также напишите метод вывода в консоль дерева, чтобы увидеть, насколько корректно работает ваша реализация. 
 */
namespace lesson_4_2
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

            Console.WriteLine("----------REMOVE TEST-----------");

            tree.RemoveItem(50);
            tree.PrintTree();  

            Console.ReadKey();
        }
    }
}
