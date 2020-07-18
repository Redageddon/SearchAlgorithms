using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using SearchAlgorithms;
using SearchAlgorithms.Algorithms;

namespace SearchAlgorithmBenchmarks
{
    public class AlgorithmBenchmarks
    {
        private readonly List<int> master = new List<int>
        {
            14, 1, 35, 247, 870, 37, 14, 4, 864595, 68, 34, 57, 3, 247, 22, 37, 8, 5, 68, 35, 6, 2, 46, 247, 870, 37, 14, 45674567, 45675, 3, 90,
            247, 22, 37, 247, 870, 37, 247, 870, 3, 14, 247, 870, 37, 14
        };

        private readonly int[] search = {247, 870, 37};

        [Benchmark]
        public void Rubiksmaster02Multi() => this.master.MultiSearch(this.search, Rubiksmaster02.Default);
    }
}