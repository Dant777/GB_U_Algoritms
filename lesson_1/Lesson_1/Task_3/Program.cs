using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл).
Пример чисел Фибоначчи:
F(0) = 0,
F(1) = 1.
Для остальных чисел:
F(N) = F(N-2) + F(N-1).
То есть для F(2) будет F(2) = F(0) + F(1) = 0 + 1 = 1. 
F(3) будет F(3) = F(1) + F(2) = 1 + 1 = 2. 
 */
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Введите число");
                int n = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine($"Число: {FibonacciNumber.NoRecursionFibonacci(n)}");
            }
           
            Console.ReadKey();

        }

    }

}
