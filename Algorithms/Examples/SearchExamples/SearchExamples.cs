#region Usings
using SearchAlgorithms.SearchAlgorithms;
#endregion

namespace Algorithms.Examples.SearchExamples
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

        public SearchExamples(uint size)
        {
            data = ExampleData.GetMoqData(size);
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
            data = ExampleData.GetMoqData(size);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Отображение результата
        /// </summary>
        /// <param name="index"></param>
        private static void Result(int index)
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
        

        #endregion
    }
}
