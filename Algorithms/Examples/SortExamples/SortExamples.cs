#region Usings
using SortAlgorithms.SortAlgorithms;
#endregion

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

        /// <summary>
        /// Пример сортировки Шелла
        /// </summary>
        public void ShellSortExample()
        {
            ShellSort.Sort(data);
        }

        /// <summary>
        /// Пример быстрой сортировки (рекурсия)
        /// </summary>
        public void QuickSortExample()
        {
            QuickSort.Sort(data);
        }

        /// <summary>
        /// Пример сортировки слиянием (рекурсия)
        /// </summary>
        public void MergeSortExample()
        {
            MergeSort.Sort(data);
        }

        #endregion

    }
}
