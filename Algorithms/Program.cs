#region Usings
using Algorithms.Services;
using Algorithms.SearchExamples;
#endregion

var examples = new SearchExamples(1_000_000);

int searchValue = new Random().Next(0, 10000);

ShowSimpleSearchResult(() => examples.SimpleSeachExample(searchValue));

ShowBarrierSearchResult(() => examples.BarrierSeachExample(searchValue));




void ShowSimpleSearchResult(Action action)
{
    Console.WriteLine("Простой поиск");

    var sw = new CustomSW(action);

    sw.ShowResult();
}

void ShowBarrierSearchResult(Action action)
{
    Console.WriteLine("Барьерный поиск");

    var sw = new CustomSW(action);

    sw.ShowResult();
}