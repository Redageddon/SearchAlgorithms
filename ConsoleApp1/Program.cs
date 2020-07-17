using BenchmarkDotNet.Running;
using SearchAlgorithms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<AlgorithmBenchmarker>();
        }
    }
}