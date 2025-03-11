#region Usings
using SearchAlgorithms.SearchAlgorithms;
#endregion

namespace Algorithms.SearchExamples
{
    /// <summary>
    /// Примеры алгоритмов поиска
    /// </summary>
    class SearchExamples
    {
        #region Private Properties

        private int[] data = [];

        #endregion

        #region Constructors

        public SearchExamples(uint size = 10)
        {
            data = GetMoqData(size);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Примеры обычного поиска
        /// </summary>
        /// <param name="value"></param>
        public void SimpleSearchExample(int value)
        {
            int result = UnSortSearch.SimpleSearch(data, value);

            Result(result);
        }
        
        /// <summary>
        /// Пример поиска с барьром
        /// </summary>
        /// <param name="value"></param>
        public void BarrierSearchExample(int value)
        {
            int result = UnSortSearch.SearchBarrier(data, value);

            Result(result);
        }

        /// <summary>
        /// Пример бинарного поиска (перед поиском массив необходимо отсортировать)
        /// </summary>
        /// <param name="value"></param>
        public void BinarySortSearchExample(int value)
        {
            int result = SortSearch.BinarySearch(data, value);

            Result(result);
        }

        /// <summary>
        /// Обновить массив данных для поиска
        /// </summary>
        /// <param name="size"></param>
        public void GenerateNewData(uint size)
        {
            data = GetMoqData(size);
        }

        /// <summary>
        /// Сортировка массива с данными
        /// </summary>
        public void SortData()
        {
            Array.Sort(data);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Отображение результата
        /// </summary>
        /// <param name="index"></param>
        private void Result(int index)
        {
            if (index != -1)
            {
                Console.WriteLine($"Объект найден под индексом {index}");
            }
            else
            {
                Console.WriteLine("Объект не найден");
            }
        }

        // Создание данных для поиска
        private static int[] GetMoqData(uint size)
        {
            int[] arr = new int[size];

            for(int i =0; i< size; i++)
            {
                arr[i] = new Random().Next(0, 10000);
            }

            return arr;
        }

        #endregion
    }
}
