
namespace SearchAlgorithmsTests
{
    internal static class MoqData
    {
        #region Private Properties

        private static readonly int[] fullArr = [
            656,
            3663,
            7456,
            41,
            778,
            425,
            7876,
            2355,
            9989,
            237,
            773,
            893,
            22,
            -121,
            -66,
            12312,
            66,
            -8816,
            65792,
            2
            ];

        private const int inFullArr = 12312;

        private const int inFullArrIndex = 15;

        private const int notInFullArr = 5475;

        private const int badIndex = -1;

        #endregion

        #region Internal Methods

        /// <summary>
        /// Набор данных для корректного поиска
        /// </summary>
        /// <returns></returns>
        internal static (int[] arr, int value, int index) GetCorrectSearchData()
        {
            return (fullArr, inFullArr, inFullArrIndex);
        }

        /// <summary>
        /// Набор данных для поиска без результата
        /// </summary>
        /// <returns></returns>
        internal static (int[] arr, int value, int index) GetBadSearchData()
        {
            return (fullArr, notInFullArr, badIndex);
        }

        /// <summary>
        /// Набор данных для пустого массива
        /// </summary>
        /// <returns></returns>
        internal static (int[] arr, int value, int index) GetEmptySearchData()
        {
            return ([], inFullArr, badIndex);
        }

        /// <summary>
        /// Набор сортированных данныз для бинарного поиска
        /// </summary>
        /// <returns></returns>
        internal static (int[] arr, int value, int index) GetCorrectSortSearchData()
        {
            int[] sortedArr = fullArr.Order().ToArray();
            int newSortIndex = Array.IndexOf(sortedArr, inFullArr);
            return (sortedArr, inFullArr, newSortIndex);
        }

        #endregion
    }
}
