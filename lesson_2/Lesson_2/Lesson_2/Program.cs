using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Требуется реализовать класс двусвязного списка и операции вставки, удаления и поиска элемента в нём в соответствии с интерфейсом.
 */
namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LincedList list = new LincedList();


            for (int i = 0; i < 10; i++)
            {
                list.AddNode(i);
            }
            Node node = list.GetNode(3);
            list.RemoveNode(node);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
