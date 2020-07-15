using System.Collections.Generic;
using NUnit.Framework;
using SearchAlgorithms;

namespace SearchAlgorithmTests
{
    public class Tests
    {
        private readonly List<int> master = new List<int>
            {14, 1, 35, 247, 870, 37, 4, 864595, 68, 34, 57, 3, 8, 5, 68, 35, 6, 2, 46, 247, 870, 37, 45674567, 45675, 3, 90};

        private readonly int[] search = {247, 870, 37};

        [Test]
        public void RubikMultiFirst()
        {
            Assert.AreEqual(this.master.RmMultiDuoSearch(this.search)[0], 3);
        }
        
        [Test]
        public void RubikMultiSecond()
        {
            Assert.AreEqual(this.master.RmMultiDuoSearch(this.search)[1], 19);
        }
        
        [Test]
        public void RubikSingle()
        {
            Assert.AreEqual(this.master.RmSingleDuoSearch(this.search), 3);
        }
        
        [Test]
        public void KnuthMultiFirst()
        {
            Assert.AreEqual(this.master.KmpMultiSearch(this.search)[0], 3);
        }
        
        [Test]
        public void KnuthMultiSecond()
        {
            Assert.AreEqual(this.master.KmpMultiSearch(this.search)[1], 19);
        }
        
        [Test]
        public void KnuthSingle()
        {
            Assert.AreEqual(this.master.KmpSingleSearch(this.search), 3);
        }
    }
}