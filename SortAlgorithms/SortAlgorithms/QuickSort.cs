
namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритм быстрой сортировки (худшее - O(n*n), среднее - O(n * log 2 n)
    /// </summary>
    public static class QuickSort
    {
        #region Public Methods

        /// <summary>
        /// Быстрая сортировка
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Метод сортировки с рекурсией внутри
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>
        private static int[] Sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            Sort(array, minIndex, pivotIndex - 1);
            Sort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        /// <summary>
        /// Обмен элементов массива
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        /// <summary>
        /// Возвращает индекс опорного элемента
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>
        private static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        #endregion
    }
}
