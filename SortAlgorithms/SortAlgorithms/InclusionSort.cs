using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритмы сортировки включениями - O(N*N)
    /// </summary>
    public static class InclusionSort
    {
        /// <summary>
        /// Сортировка простым включением 
        /// </summary>
        /// <param name="arr"></param>
        public static void SimpleInsertion(int[] arr)
        {

            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];

                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j--];
                }

                arr[j + 1] = temp;
            }
        }

        /// <summary>
        /// Сортировка бинарным включением
        /// </summary>
        /// <param name="arr"></param>
        public static void BinaryInclusion(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int left = 0;
                int right = i - 1;

                while (left <= right)
                {
                    int m = (left + right) / 2;

                    if (temp < arr[m])
                    {
                        right = m - 1;
                    }
                    else
                    {
                        left = m + 1;
                    }
                }

                for (int j = i - 1; j >= left; j--)
                {
                    arr[j + 1] = arr[j];
                }

                arr[left] = temp;

            }
        }
    }
}
