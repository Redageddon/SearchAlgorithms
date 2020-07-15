using System.Collections.Generic;

namespace SearchAlgorithms
{
    public interface ISearchAlgorithm
    {
        public int SingleSearch<T>(IReadOnlyList<T> input, IReadOnlyList<T> match);
        public List<int> MultiSearch<T>(IReadOnlyList<T> input, IReadOnlyList<T> match);
    }
}