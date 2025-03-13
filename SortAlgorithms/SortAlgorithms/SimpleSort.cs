
namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритм простой сортировки - O(N*N)
    /// </summary>
    public static class SimpleSort
    {
        public static void Sort(int[] arr)
        {
            // Временная переменная для обмена элементов
            int temp;

            // Индекс минимального элемента в текущем диапазоне
            int minIndex;

            // Внешний цикл для каждого элемента массива
            for (int i =0; i < arr.Length - 1; i++)
            {
                // Запоминаем текущий элемент
                temp = arr[i];

                // Считаем, что текущий элемент - минимальный
                minIndex = i;

                // Внутренний цикл для поиска минимального элемента в оставшейся части массива
                for (int j = i+1; j< arr.Length; j++)
                {
                    // Если нашли меньший элемент, обновляем минимальный элемент и его индекс
                    if (arr[j] < temp)
                    {
                        temp = arr[j];
                        minIndex = j;
                    }
                }

                // Если найден минимальный элемент, который не является текущим,
                // то меняем их местами
                if (i != minIndex)
                {
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}
