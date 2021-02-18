using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public static class FibonacciNumber
    {
        public static int RecursionFibonacci(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;
            return RecursionFibonacci(number - 1) + RecursionFibonacci(number - 2);
        }

        public static int NoRecursionFibonacci(int number)
        {
            int count = 0;
            int fib_1 = 1;
            int fib_2 = 1;
            int sum = 0;
            while (count < number - 2)
            {
                sum = fib_1 + fib_2;
                fib_1 = fib_2;
                fib_2 = sum;
                count++;
            }
            return fib_2;
        }
    }
}
