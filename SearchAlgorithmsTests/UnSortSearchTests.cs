#region Usings
using SearchAlgorithms.SearchAlgorithms;
#endregion

namespace SearchAlgorithmsTests
{
    /// <summary>
    /// Тесты для поиска несортированного массива 
    /// </summary>
    public class UnSortSearchTests
    {
        #region SimpleSearch

        [Fact]
        public void SimpleSearchInArr()
        {
            var moq = MoqData.GetCorrectSearchData();

            int result = UnSortSearch.SimpleSearch(moq.arr, moq.value);

            Assert.True(result == moq.index);
        }

        [Fact]
        public void SimpleSearchNotInArr()
        {
            var moq = MoqData.GetBadSearchData();

            int result = UnSortSearch.SimpleSearch(moq.arr, moq.value);

            Assert.True(result == moq.index);
        }

        [Fact]
        public void SimpleSearchEmpyArr()
        {
            var moq = MoqData.GetEmptySearchData();

            int result = UnSortSearch.SimpleSearch(moq.arr, moq.value);

            Assert.True(result == moq.index);
        }

        #endregion

        #region BarrierSearch

        [Fact]
        public void BarrierSearchInArr()
        {
            var moq = MoqData.GetCorrectSearchData();

            int result = UnSortSearch.SearchBarrier(moq.arr, moq.value);

            Assert.True(result == moq.index);
        }

        [Fact]
        public void BarrierSearchNotInArr()
        {
            var moq = MoqData.GetBadSearchData();

            int result = UnSortSearch.SearchBarrier(moq.arr, moq.value);

            Assert.True(result == moq.index);
        }

        [Fact]
        public void BarrierSearchEmpyArr()
        {
            var moq = MoqData.GetEmptySearchData();

            int result = UnSortSearch.SearchBarrier(moq.arr, moq.value);

            Assert.True(result == moq.index);
        }

        #endregion
    }
}