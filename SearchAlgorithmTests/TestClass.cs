using System;

namespace SearchAlgorithmTests
{
    public class TestClass : IEquatable<TestClass>
    {
        public int  A                     { get; set; }
        public bool Equals(TestClass other) => this.A == other.A;
    }
}