#region Usings
using System.Diagnostics;
#endregion

namespace Algorithms.Services
{
    /// <summary>
    /// Кастом StopWatch для выполнения делегата
    /// </summary>
    public class CustomSW
    {
        #region Private Properties

        private readonly Action action;

        private Stopwatch stopWatch;

        #endregion

        #region Constructors

        public CustomSW(Action action)
        {
            this.stopWatch = new Stopwatch();
            this.action = action;

        }

        #endregion

        #region Public Methods

        public void ShowResult()
        {
            stopWatch.Start();

            action.Invoke();

            stopWatch.Stop();

            Console.WriteLine($"Время выполнения {stopWatch.Elapsed}");
        }

        #endregion
    }
}
