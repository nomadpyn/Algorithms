
namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритм сортировки Шелла - O(n*n)
    /// </summary>
    public static class ShellSort
    {
        /// <summary>
        /// Сортировка алгоримом Шелла
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            // Изначально устанавливаем шаг, равный половине длины массива
            int step = arr.Length / 2;

            // Пока шаг больше или равен 1
            while (step >= 1)
            {
                // Для каждого элемента массива, начиная с индекса 'step'
                int k = step;

                for (int i = k; i < arr.Length; i++)
                {
                    int temp = arr[i];

                    // Индекс для сравнения с элементами, которые на 'k' позиций назад
                    int j = i - k;

                    // Внутренний цикл сортировки вставками, с шагом 'k'
                    // Перемещаем элементы, большие чем temp, на позицию вперед
                    while ((j >= 0) && (temp < arr[j]))
                    {
                        // Сдвигаем элементы вправо
                        arr[j + k] = arr[j];

                        // Переходим к следующему элементу с шагом 'k'
                        j = j - k;
                    }

                    // Вставляем temp в правильное место
                    arr[j + k] = temp;
                }

                // Уменьшаем шаг с использованием формулы, чтобы улучшить эффективность
                step = 3 * step / 5;
            }
        }
    }
}
