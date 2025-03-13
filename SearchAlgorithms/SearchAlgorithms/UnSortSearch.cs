
namespace SearchAlgorithms.SearchAlgorithms
{
    /// <summary>
    /// Поиск в неотсортированных алгоритамх O(n)
    /// </summary>
    public static class UnSortSearch
    {
        /// <summary>
        /// Последовательный просмотр какждого элемента массива 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SimpleSearch(int [] arr, int value)
        {
            // Проходим по всем элементам массива с индексом от 0 до arr.Length - 1
            for (int i = 0; i< arr.Length; i++)
            {
                // Если текущий элемент массива равен искомому значению
                if (arr[i] == value)
                {
                    return i;
                }
            }

            // Если элемент не найден, возвращаем -1
            return -1;
                   
        }
        
        /// <summary>
        /// Поиск с Барьером
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SearchBarrier(int[] arr, int value)
        {
            // Сохраняем длину исходного массива
            int length = arr.Length;

            // Увеличиваем размер массива на 1, чтобы можно было добавить искомое значение в конец
            Array.Resize<int>(ref arr, ++length);

            // Ставим искомое значение в конец массива
            arr[length - 1] = value;

            int i = 0;

            // Цикл продолжается, пока текущий элемент массива не будет равен искомому значению
            while (arr[i] != value)
            {
                i++;
            }

            // Если мы нашли искомое значение и оно не находится в "барьерной" позиции (в конце массива),
            // возвращаем индекс этого элемента
            if (i < length - 1)
            {
                return i;
            }
            // Если значение находится в конце массива, это означает, что мы добавили его как "барьер",
            // и оно не является настоящим элементом массива, поэтому возвращаем -1
            else
            {
                return -1;
            }            
        }
    }
}
