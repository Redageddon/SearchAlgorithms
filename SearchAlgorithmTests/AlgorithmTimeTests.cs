using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using SearchAlgorithms;
using SearchAlgorithms.Algorithms;

namespace SearchAlgorithmTests
{
    public class AlgorithmTimeTests
    {
        public TestContext TestContext { get; set; }

        private readonly ISearchAlgorithm rubiksmaster02   = new Rubiksmaster02();
        private readonly ISearchAlgorithm knuthMorrisPratt = new KnuthMorrisPratt();

        private readonly List<int>  randomFillList = new List<int>();
        private readonly List<long> times          = new List<long>();
        private readonly Random     random         = new Random();
        private readonly Stopwatch  stopwatch      = new Stopwatch();

        private const int NumberOfListSize    = 100_000;
        private const int NumberOfRepetitions = 5000;
        private const int ChunkSize           = 4;
        private const int RandomIntMax = 1000;

        [Test]
        public void TimeTest()
        {
            this.TestSpecificAlgorithm(this.rubiksmaster02);
            this.TestSpecificAlgorithm(this.knuthMorrisPratt);
        }

        private void TestSpecificAlgorithm(ISearchAlgorithm algorithm)
        {
            for (int i = 0; i < NumberOfRepetitions; i++)
            {
                for (int j = 0; j < NumberOfListSize; j++)
                {
                    this.randomFillList.Add(this.random.Next(0, RandomIntMax));
                }

                List<int> randomChunk = this.randomFillList.GetRange(this.random.Next(0, NumberOfListSize - ChunkSize), ChunkSize);

                this.stopwatch.Start();
                this.randomFillList.SingleSearch(randomChunk, algorithm);
                this.times.Add(this.stopwatch.ElapsedMilliseconds);
                this.stopwatch.Reset();
            }
            
            TestContext.WriteLine($"{algorithm} time ave: {this.times.Average()}");

            this.times.Clear();
        }
    }
}