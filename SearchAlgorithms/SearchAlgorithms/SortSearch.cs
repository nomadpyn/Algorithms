
namespace SearchAlgorithms.SearchAlgorithms
{
    public static class SortSearch
    {
        /// <summary>
        /// Метод бинароного поиска для отсортированного массива (будет некорректный поиск)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BinarySearch(int[]arr, int value)
        {
            int m, left = 0, right = arr.Length - 1;

            do
            {
                m = (left + right) / 2;

                if (value > arr[m])
                {
                    left = m + 1;
                }
                else
                {
                    right = m - 1;
                }
            }
            while ((arr[m] != value) && (left <= right));

            if(arr[m] == value)
            {
                return m;
            }
            else
            {
                return -1;
            }
        }
    }
}
