#region Usings
using Algorithms.Examples.SortExamples;
using Algorithms.Services;
#endregion

Console.WriteLine("Алгоритмы");

SortExamples se = new SortExamples(10000000);

CustomSW sw = new CustomSW(() => se.QuickSortExample());

sw.ShowResult();
