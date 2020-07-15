using System.Collections.Generic;
using NUnit.Framework;
using SearchAlgorithms;

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
        public void RubikMultiFirstTest1() => Assert.AreEqual(this.master.RmMultiDuoSearch(this.search)[0], 3);

        [Test]
        public void RubikMultiSecondTest1() => Assert.AreEqual(this.master.RmMultiDuoSearch(this.search)[1], 23);

        [Test]
        public void RubikMultiFirstTest2() => Assert.AreEqual(this.master.RmMultiDuoSearch(this.search2)[0], 3);

        [Test]
        public void RubikMultiSecondTest2() => Assert.AreEqual(this.master.RmMultiDuoSearch(this.search2)[1], 23);

        [Test]
        public void RubikMultiThirdTest1() => Assert.AreEqual(this.master.RmMultiDuoSearch(this.search)[2], 34);

        [Test]
        public void RubikMultiThirdTest2() => Assert.AreEqual(this.master.RmMultiDuoSearch(this.search2)[2], 41);

        [Test]
        public void RubikSingleTest1() => Assert.AreEqual(this.master.RmSingleDuoSearch(this.search), 3);

        [Test]
        public void RubikSingleTest2() => Assert.AreEqual(this.master.RmSingleDuoSearch(this.search2), 3);

        [Test]
        public void KnuthMultiFirstTest1() => Assert.AreEqual(this.master.KmpMultiSearch(this.search)[0], 3);

        [Test]
        public void KnuthMultiSecondTest1() => Assert.AreEqual(this.master.KmpMultiSearch(this.search)[1], 23);

        [Test]
        public void KnuthMultiFirstTest2() => Assert.AreEqual(this.master.KmpMultiSearch(this.search2)[0], 3);

        [Test]
        public void KnuthMultiSecondTest2() => Assert.AreEqual(this.master.KmpMultiSearch(this.search2)[1], 23);

        [Test]
        public void KnuthSingleTest1() => Assert.AreEqual(this.master.KmpSingleSearch(this.search), 3);

        [Test]
        public void KnuthSingleTest2() => Assert.AreEqual(this.master.KmpSingleSearch(this.search2), 3);
    }
}