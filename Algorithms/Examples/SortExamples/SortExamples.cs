
using SortAlgorithms.SortAlgorithms;

namespace Algorithms.Examples.SortExamples
{
    class SortExamples
    {
        #region Private Properties

        private int[] data = [];

        #endregion

        #region Constructors

        public SortExamples(uint size)
        {
            data = ExampleData.GetMoqData(size);
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Пример простой сортировки 
        /// </summary>
        public void SimpleSortExample()
        {
            SimpleSort.Sort(data);
        }

        /// <summary>
        /// Пример простой сортировки вставками 
        /// </summary>
        public void InsertionSimpleSortExample()
        {
            InclusionSort.SimpleInsertion(data);
        }

        /// <summary>
        /// Пример бинарной сортировки вставками
        /// </summary>
        public void InclusionBinarySortExample()
        {
            InclusionSort.BinaryInclusion(data);
        }

        /// <summary>
        /// Пример сортировки пузырьком
        /// </summary>
        public void ExchangeBubbleSortExample()
        {
            ExchangeSort.BubbleSort(data);
        }

        /// <summary>
        /// Пример сортировки шейкером
        /// </summary>
        public void ExchangeShakerSortExample()
        {
            ExchangeSort.ShakerSort(data);
        }

        #endregion

    }
}
