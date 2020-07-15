using System.Collections.Generic;

namespace SearchAlgorithms
{
    public static class AlgorithmSearcher
    {
        public static List<int> MultiSearch<T>(this IReadOnlyList<T> input, IReadOnlyList<T> match, ISearchAlgorithm searchAlgorithm)
        {
            return searchAlgorithm.MultiSearch(input, match);
        }
        
        public static int SingleSearch<T>(this IReadOnlyList<T> input, IReadOnlyList<T> match, ISearchAlgorithm searchAlgorithm)
        {
            return searchAlgorithm.SingleSearch(input, match);
        }
    }
}