
namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритмы сортировки обменом
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
    }
}
