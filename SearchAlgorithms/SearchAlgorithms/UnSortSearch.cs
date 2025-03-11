
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
            for (int i = 0; i< arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }

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
            int length = arr.Length;
            
            // увеличиваем размера массива на 1
            Array.Resize<int>(ref arr, ++length);

            // ставим значение в конец
            arr[length - 1] = value;

            int i = 0;


            while (arr[i] != value)
            {
                i++;
            }

            if (i < length - 1)
            {
                return i;
            }
            else
            {
                return -1;
            }            
        }
    }
}
