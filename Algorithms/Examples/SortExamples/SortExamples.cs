
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

        public void SimpleSortExample()
        {
            SimpleSort.Sort(data);
        }

        public void InsertionSimpleSortExample()
        {
            InclusionSort.SimpleInsertion(data);
        }

        public void InclusionBinarySortExample()
        {
            InclusionSort.BinaryInclusion(data);
        }

        #endregion

    }
}
