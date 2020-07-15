using System.Collections.Generic;

namespace SearchAlgorithms
{
    public interface ISearchAlgorithm
    {
        public int SingleSearch<T>(IReadOnlyList<T> input, IReadOnlyList<T> match, int start, int count);
        public List<int> MultiSearch<T>(IReadOnlyList<T> input, IReadOnlyList<T> match, int start, int count);
    }
}