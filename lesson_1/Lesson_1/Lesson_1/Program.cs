using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.
 */
namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВедите число:");
                int n = Convert.ToInt32( Console.ReadLine());
                SimpleNumber simpleNumber = new SimpleNumber();

                if (simpleNumber.CheckNumber(n))
                {
                    Console.WriteLine("***Простое***");
                }
                else
                {
                    Console.WriteLine("***Не простое***");
                }
            }
           
            
            Console.ReadKey();
        }
      
    }
}
