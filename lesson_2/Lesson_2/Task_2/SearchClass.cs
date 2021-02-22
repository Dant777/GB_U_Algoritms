using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class SearchClass
    {
        /// <summary>
        /// Бинарный поиск по массиву чисел
        /// </summary>
        /// <param name="list">Сортированный массив для поиска</param>
        /// <param name="searchNumber">Искомое значение</param>
        /// <returns>индекс в массиве равный искомому числу</returns>
        public static int BinarySearch(int [] list, int searchNumber)
        {
            int low = 0;
            int high = list.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guessNum = list[mid];
                if (guessNum == searchNumber)
                    return mid;
                else if (guessNum > searchNumber)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }

}
