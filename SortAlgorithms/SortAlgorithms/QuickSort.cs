
namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритм быстрой сортировки (худшее - O(n*n), среднее - O(n * log n)
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
            // Базовый случай: если левая граница больше или равна правой, массив отсортирован или состоит из одного элемента
            if (minIndex >= maxIndex)
            {
                return array;
            }

            // Разделяем массив, выбираем опорный элемент и получаем его индекс
            var pivotIndex = Partition(array, minIndex, maxIndex);

            // Рекурсивно сортируем левую и правую часть массива, исключая опорный элемент
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
            (y, x) = (x, y);
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
            // Инициализируем индекс опорного элемента
            var pivot = minIndex - 1;

            // Проходим по массиву от minIndex до maxIndex (исключая maxIndex)
            for (var i = minIndex; i < maxIndex; i++)
            {
                // Если текущий элемент меньше опорного, меняем его местами
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            // После завершения цикла перемещаем опорный элемент на его правильную позицию
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        #endregion
    }
}
