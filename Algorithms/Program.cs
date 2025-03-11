
using Algorithms.Examples.SortExamples;
using Algorithms.Services;

Console.WriteLine("Алгоритмы и структуры данных");

SortExamples se = new SortExamples(100000);

CustomSW sw = new CustomSW(() => se.SimpleSortExample());

sw.ShowResult();
