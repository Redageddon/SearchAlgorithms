using BenchmarkDotNet.Running;

namespace SearchAlgorithmBenchmarks
{
    internal static class Program
    {
        private static void Main() => BenchmarkRunner.Run<AlgorithmBenchmarks>();
    }
}