
namespace SortAlgorithms.SortAlgorithms
{
    /// <summary>
    /// Алгоритм простой сортировки - O(N*N)
    /// </summary>
    public static class SimpleSort
    {
        public static void Sort(int[] arr)
        {
            int temp;
            int minIndex;

            for(int i =0; i < arr.Length - 1; i++)
            {
                temp = arr[i];
                minIndex = i;

                for(int j = i+1; j< arr.Length; j++)
                {
                    if (arr[j] < temp)
                    {
                        temp = arr[j];
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}
