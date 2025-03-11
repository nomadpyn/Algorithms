using SortAlgorithms.SortAlgorithms;

namespace SortAlgoritmsTests
{
    public class SimpleSortTests
    {
        [Fact]
        public void SimpleSortTest()
        {
            var arr1 = MoqData.GetIntArray();

            var arr2 = MoqData.GetSortArray();

            SimpleSort.Sort(arr1);

            Assert.Equal(arr1, arr2);
        }
    }
}