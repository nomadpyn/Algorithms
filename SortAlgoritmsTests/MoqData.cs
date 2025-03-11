
namespace SortAlgoritmsTests
{
    // Тестовые данные для проверки алгоритмов сортировки
    internal static class MoqData
    {
        #region Private Properties

        private static readonly int[] Arr = [524, 661, 62, 9, 13, 0, -13, 224, 91, 23];

        #endregion

        #region Internal Methods

        /// <summary>
        /// Возвращает изначальный массив
        /// </summary>
        /// <returns></returns>
        internal static int[] GetIntArray()
        {
            return Arr;
        }

        /// <summary>
        /// Возвращает отсортированный массив для проверки
        /// </summary>
        /// <returns></returns>
        internal static int[] GetSortArray()
        {
            return Arr.Order().ToArray();
        }

        #endregion
    }
}
