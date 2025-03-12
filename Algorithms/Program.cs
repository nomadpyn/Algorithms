
using Algorithms.Examples.SortExamples;
using Algorithms.Services;

Console.WriteLine("Алгоритмы и структуры данных");

SortExamples se = new SortExamples(1000000);

CustomSW sw = new CustomSW(() => se.ShellSortExample());

sw.ShowResult();
