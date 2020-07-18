using System;
using System.Collections.Generic;

namespace SearchAlgorithms
{
    public static class AlgorithmSearcher
    {
        public static List<int> MultiSearch<T>(this IReadOnlyList<T> input, IReadOnlyList<T> match, ISearchAlgorithm searchAlgorithm, int start = 0, int count = int.MaxValue)
            where T : IEquatable<T>
        {
            return searchAlgorithm.MultiSearch(input, match, start, count);
        }
        
        public static int SingleSearch<T>(this IReadOnlyList<T> input, IReadOnlyList<T> match, ISearchAlgorithm searchAlgorithm, int start = 0, int count = int.MaxValue)
            where T : IEquatable<T>
        {
            return searchAlgorithm.SingleSearch(input, match, start, count);
        }
    }
}