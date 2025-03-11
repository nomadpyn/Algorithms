using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmsTests
{
    internal static class MoqData
    {
        #region Private Properties

        private static readonly int[] fullArr = [656, 3663, 7456, 41, 778, 425, 7876, 2355, 9989, 237];

        private const int inFullArr = 425;

        private const int inFullArrIndex = 5;

        private const int notInFullArr = 5475;

        private const int badIndex = -1;

        #endregion

        #region Internal Methods

        /// <summary>
        /// Набор данных для корректного поиска
        /// </summary>
        /// <returns></returns>
        internal static (int[] arr , int value , int index) GetCorrectSearchData()
        {
            return (fullArr, inFullArr, inFullArrIndex);
        }

        /// <summary>
        /// Набор данных для поиска без результата
        /// </summary>
        /// <returns></returns>
        internal static (int[] arr, int value, int index) GetBadSearchData()
        {
            return (fullArr, notInFullArr, -1);
        }

        /// <summary>
        /// Набор данных для пустого массива
        /// </summary>
        /// <returns></returns>
        internal static (int[] arr, int value, int index) GetEmptySearchData()
        {
            return ([], inFullArr, -1);
        }

        #endregion
    }
}
