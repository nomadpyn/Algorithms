
namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритм метода сортировки слиянием O(n * log n)
    /// </summary>
    public static class MergeSort
    {
        #region Public Methods

        /// <summary>
        /// Сортировка методом слияния
        /// </summary>
        /// <param name="array"></param>
        public static void Sort(int[] array)
        {
            // Вызываем внутреннюю рекурсивную функцию сортировки, передавая весь массив.
            Sort(array, 0, array.Length - 1);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Сортировка массива с рекурсией внутри
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lowIndex"></param>
        /// <param name="highIndex"></param>
        /// <returns></returns>
        private static int[] Sort(int[] array, int lowIndex, int highIndex)
        {
            // Если индекс начала меньше индекса конца, продолжаем делить массив
            if (lowIndex < highIndex)
            {
                // Находим середину массива
                var middleIndex = (lowIndex + highIndex) / 2;

                // Рекурсивно сортируем левую половину массива
                Sort(array, lowIndex, middleIndex);

                // Рекурсивно сортируем правую половину массива
                Sort(array, middleIndex + 1, highIndex);

                // После сортировки левой и правой половин сливаем их вместе
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        /// <summary>
        /// Метод слияния массивов
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lowIndex"></param>
        /// <param name="middleIndex"></param>
        /// <param name="highIndex"></param>
        private static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            // Указатели на начало левой и правой половины
            var left = lowIndex;
            var right = middleIndex + 1;

            // Временный массив для хранения отсортированных элементов
            var tempArray = new int[highIndex - lowIndex + 1];

            // Индекс для временного массива
            var index = 0;

            // Сравниваем элементы из левой и правой половины и добавляем наименьший в временный массив
            while ((left <= middleIndex) && (right <= highIndex))
            {
                // Если элемент левой половины меньше, добавляем его в tempArray
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    // Сдвигаем указатель на следующий элемент левой половины
                    left++;
                }
                // Иначе добавляем элемент правой половины в tempArray
                else
                {
                    tempArray[index] = array[right];
                    // Сдвигаем указатель на следующий элемент правой половины
                    right++;
                }

                index++;
            }

            // Если остались элементы в левой половине, добавляем их в tempArray
            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            // Переносим отсортированные элементы из tempArray обратно в исходный массив
            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        #endregion
    }
}
