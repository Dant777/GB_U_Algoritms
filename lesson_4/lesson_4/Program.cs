using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
/*
 Заполните массив и HashSet случайными строками, не менее 10 000 строк. Строки можно сгенерировать.
 Потом выполните замер производительности проверки наличия строки в массиве и HashSet. 
 Выложите код и результат замеров.
 */

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            
        }

    }

    public class BechmarkClass
    {
        HashSet<string> hashSetList = new HashSet<string>();
        string[] stringArr = new string[10_000];

        public BechmarkClass()
        {
            FillingHashSet();
            FillingArr();

        }

        public bool SearchInArr(string[] arr, string serchStr)
        {
            bool isFind = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == serchStr)
                {
                    isFind = true;
                    break;
                }
            }
            return isFind;
        }

        [Benchmark]
        public void TestFindInArr()
        {
            SearchInArr(stringArr, "Test data #9999");

        }

        [Benchmark]
        public void TestFindInHashSet()
        {
            hashSetList.Contains("Test data #9999");

        }


        private void FillingHashSet()
        {
            string testStr = "Test data #";
            for (int i = 0; i < 10_000; i++)
            {
                hashSetList.Add(testStr + i);
            }
        }
        private void FillingArr()
        {
            string testStr = "Test data #";
            for (int i = 0; i < 10_000; i++)
            {
                stringArr[i] = testStr + i;
            }
        }

    }
}
