#region Usings
using SearchAlgorithms.SearchAlgorithms;
#endregion

namespace SearchAlgorithmsTests
{
    /// <summary>
    /// Тесты для отсортированного массива
    /// </summary>
    public class SortSearchTests
    {
        #region SimpleSearch

        [Fact]
        public void BinarySearchInArr()
        {
            var moq = MoqData.GetCorrectSortSearchData();

            int result = UnSortSearch.SimpleSearch(moq.arr, moq.value);

            Assert.True(result == moq.index);
        }

        [Fact]
        public void BinarySearchNotInArr()
        {
            var moq = MoqData.GetBadSearchData();

            int result = UnSortSearch.SimpleSearch(moq.arr, moq.value);

            Assert.True(result == moq.index);
        }

        [Fact]
        public void BinarySearchEmpyArr()
        {
            var moq = MoqData.GetEmptySearchData();

            int result = UnSortSearch.SimpleSearch(moq.arr, moq.value);

            Assert.True(result == moq.index);
        }

        #endregion
    }
}
