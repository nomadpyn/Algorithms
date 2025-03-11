
namespace Algorithms.Examples
{
    /// <summary>
    /// Класс подготовки данных для алгоритмов
    /// </summary>
    public static class ExampleData
    {
        // Создание данных для поиска
        public static int[] GetMoqData(uint size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = new Random().Next(-10000, 10000);
            }

            return arr;
        }
    }
}
