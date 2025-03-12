
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
            for(int i=1; i< arr.Length; i++)
            {
                for(int j = arr.Length-1; j >= i; j--)
                {
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
            int left = 1;
            int right = arr.Length - 1;
            int last = right;


            do
            {
                for (int j = right; j >= left; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        last = j;
                    }
                }

                left = last;

                for (int j = left; j <= right; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        last = j;
                    }
                }

                right = last - 1;
            }
            while (left < right);
        }
    }
}
