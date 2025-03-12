using SortAlgorithms.SortAlgorithms;

namespace SortAlgoritmsTests
{
    public class SortTests
    {
        [Fact]
        public void SimpleSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            SimpleSort.Sort(arr1);

            Assert.Equal(arr2, arr1);
        }

        [Fact]
        public void SimpleInclusionSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            InclusionSort.SimpleInsertion(arr1);

            Assert.Equal(arr2, arr1);
        }

        [Fact]
        public void BinaryInclusionSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            InclusionSort.BinaryInclusion(arr1);

            Assert.Equal(arr2, arr1);
        }

        [Fact]
        public void BubbleSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            ExchangeSort.BubbleSort(arr1);

            Assert.Equal(arr2, arr1);
        }
    }
}