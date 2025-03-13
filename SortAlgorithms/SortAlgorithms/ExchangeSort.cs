
namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритмы сортировки обменом - O(n*n)
    /// </summary>
    public static class ExchangeSort
    {
        /// <summary>
        /// Алгоритм сортировки "пузырьком"
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            // Внешний цикл, проходящий по всем элементам массива
            for (int i=1; i< arr.Length; i++)
            {
                // Внутренний цикл, который с каждым шагом проходит по уменьшающемуся диапазону массива
                for (int j = arr.Length-1; j >= i; j--)
                {
                    // Если предыдущий элемент больше текущего, меняем их местами
                    if (arr[j-1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Шейкерная сортировка
        /// </summary>
        /// <param name="arr"></param>
        public static void ShakerSort(int[] arr)
        {
            // Начальная позиция для левой границы
            int left = 1;

            // Начальная позиция для левой границы
            int right = arr.Length - 1;

            // Переменная для отслеживания последней позиции обмена
            int last = right;


            do
            {
                // Первый проход справа налево
                for (int j = right; j >= left; j--)
                {
                    // Если предыдущий элемент больше текущего, меняем их местами
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;

                        // Обновляем последнюю позицию обмена
                        last = j;
                    }
                }

                // Обновляем левую границу для следующего прохода
                left = last;

                // Второй проход слева направо
                for (int j = left; j <= right; j++)
                {
                    // Если предыдущий элемент больше текущего, меняем их местами
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;

                        // Обновляем последнюю позицию обмена
                        last = j;
                    }
                }

                // Обновляем правую границу для следующего прохода
                right = last - 1;
            }
            // Цикл продолжается, пока левая граница не пересечет правую
            while (left < right);
        }
    }
}
