#region Usings
using SortAlgorithms.SortAlgorithms;
#endregion

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
        public void SimpleInsertionSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            InsertionSort.SimpleInsertion(arr1);

            Assert.Equal(arr2, arr1);
        }

        [Fact]
        public void BinaryInsertionSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            InsertionSort.BinaryInsertion(arr1);

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

        [Fact]
        public void ShakerSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            ExchangeSort.ShakerSort(arr1);

            Assert.Equal(arr2, arr1);
        }

        [Fact]
        public void ShellSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            ShellSort.Sort(arr1);

            Assert.Equal(arr2, arr1);
        }

        [Fact]
        public void QuickSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            QuickSort.Sort(arr1);

            Assert.Equal(arr2, arr1);
        }

        [Fact]
        public void MergeSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            MergeSort.Sort(arr1);

            Assert.Equal(arr2, arr1);
        }
    }
}