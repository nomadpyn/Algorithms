﻿
namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритмы сортировки включениями - O(N*N)
    /// </summary>
    public static class InsertionSort
    {
        /// <summary>
        /// Сортировка простым включением 
        /// </summary>
        /// <param name="arr"></param>
        public static void SimpleInsertion(int[] arr)
        {
            // Цикл, который начинает сортировку с второго элемента (i = 1)
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];

                // Инициализируем j на индекс предыдущего элемента
                int j = i - 1;

                // Внутренний цикл перемещает элементы, которые больше чем temp, на одну позицию вправо
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Вставляем элемент temp в его правильное место в отсортированной части массива
                arr[j + 1] = temp;
            }
        }

        /// <summary>
        /// Сортировка бинарным включением
        /// </summary>
        /// <param name="arr"></param>
        public static void BinaryInsertion(int[] arr)
        {
            // Цикл, начиная с 1-го элемента, т.к. первый элемент считается отсортированным
            for (int i = 1; i < arr.Length; i++)
            {
                // Сохраняем текущий элемент
                int temp = arr[i];

                // Инициализируем левую границу поиска
                int left = 0;

                // Инициализируем правую границу поиска
                int right = i - 1;

                // Бинарный поиск для нахождения позиции, куда нужно вставить текущий элемент
                while (left <= right)
                {
                    // Находим средний элемент
                    int m = (left + right) / 2;

                    // Если текущий элемент меньше среднего, ищем слева
                    if (temp < arr[m])
                    {
                        right = m - 1;
                    }
                    // Если текущий элемент больше или равен среднему, ищем справа
                    else
                    {
                        left = m + 1;
                    }
                }

                // После бинарного поиска, перемещаем элементы влево, чтобы освободить место для temp
                for (int j = i - 1; j >= left; j--)
                {
                    // Сдвигаем элементы, большие чем temp, на одну позицию вправо
                    arr[j + 1] = arr[j];
                }

                // Вставляем элемент на найденную позицию
                arr[left] = temp;

            }
        }
    }
}
