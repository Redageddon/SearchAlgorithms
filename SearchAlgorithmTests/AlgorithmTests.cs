using System;
using System.Collections.Generic;
using NUnit.Framework;
using SearchAlgorithms;
using SearchAlgorithms.Algorithms;

namespace SearchAlgorithmTests
{
    public class Tests
    {
        private readonly List<int> master = new List<int>
        {
            14, 1, 35, 247, 870, 37, 14, 4, 864595, 68, 34, 57, 3, 247, 22, 37, 8, 5, 68, 35, 6, 2, 46, 247, 870, 37, 14, 45674567, 45675, 3, 90,
            247, 22, 37, 247, 870, 37, 247, 870, 3, 14, 247, 870, 37, 14
        };

        private readonly int[] search  = {247, 870, 37};
        private readonly int[] search2 = {247, 870, 37, 14};

        [Test]
        public void RubikAllTest()
        {
            int[] nums1 = {1, 2, 3};
            int[] nums2 = {1, 2, 3};
            Assert.AreEqual(nums1.MultiSearch(nums2, Rubiksmaster02.Default)[0], 0);
        }

        [Test]
        public void ClassTest()
        {
            List<TestClass> testClasses = new List<TestClass>{new TestClass{A = 1}, new TestClass{A = 2}, new TestClass{A = 3}};
            List<TestClass> testClassesSearch = new List<TestClass>{new TestClass{A = 2}, new TestClass{A = 3}};
            
            Assert.AreEqual(testClasses.MultiSearch(testClassesSearch, Rubiksmaster02.Default), 1);
        }

        [Test]
        public void RubikMultiFirstTest1() => Assert.AreEqual(this.master.MultiSearch(this.search, Rubiksmaster02.Default)[0], 3);

        [Test]
        public void RubikMultiSecondTest1() => Assert.AreEqual(this.master.MultiSearch(this.search, Rubiksmaster02.Default)[1], 23);

        [Test]
        public void RubikMultiFirstTest2() => Assert.AreEqual(this.master.MultiSearch(this.search2, Rubiksmaster02.Default)[0], 3);

        [Test]
        public void RubikMultiSecondTest2() => Assert.AreEqual(this.master.MultiSearch(this.search2, Rubiksmaster02.Default)[1], 23);

        [Test]
        public void RubikMultiThirdTest1() => Assert.AreEqual(this.master.MultiSearch(this.search, Rubiksmaster02.Default)[2], 34);

        [Test]
        public void RubikMultiThirdTest2() => Assert.AreEqual(this.master.MultiSearch(this.search2, Rubiksmaster02.Default)[2], 41);

        [Test]
        public void RubikSingleTest1() => Assert.AreEqual(this.master.SingleSearch(this.search, Rubiksmaster02.Default), 3);

        [Test]
        public void RubikSingleTest2() => Assert.AreEqual(this.master.SingleSearch(this.search2, Rubiksmaster02.Default), 3);

        [Test]
        public void KnuthMultiFirstTest1() => Assert.AreEqual(this.master.MultiSearch(this.search, KnuthMorrisPratt.Default)[0], 3);

        [Test]
        public void KnuthMultiSecondTest1() => Assert.AreEqual(this.master.MultiSearch(this.search, KnuthMorrisPratt.Default)[1], 23);

        [Test]
        public void KnuthMultiFirstTest2() => Assert.AreEqual(this.master.MultiSearch(this.search2, KnuthMorrisPratt.Default)[0], 3);

        [Test]
        public void KnuthMultiSecondTest2() => Assert.AreEqual(this.master.MultiSearch(this.search2, KnuthMorrisPratt.Default)[1], 23);

        [Test]
        public void KnuthSingleTest1() => Assert.AreEqual(this.master.SingleSearch(this.search, KnuthMorrisPratt.Default), 3);

        [Test]
        public void KnuthSingleTest2() => Assert.AreEqual(this.master.SingleSearch(this.search2, KnuthMorrisPratt.Default), 3);
    }
}