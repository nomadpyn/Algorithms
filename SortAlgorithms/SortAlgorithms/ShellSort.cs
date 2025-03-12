
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
            int step = arr.Length / 2;

            while (step >= 1)
            {
                int k = step;

                for (int i = k; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j = i - k;

                    while ((j >= 0) && (temp < arr[j]))
                    {
                        arr[j + k] = arr[j];
                        j = j - k;
                    }

                    arr[j + k] = temp;
                }

                step = 3 * step / 5;
            }
        }
    }
}
