using System.Collections.Generic;
using NUnit.Framework;
using HackerRankTest1;
using System.Linq;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            List<List<int>> mat = new()
            {
                new() {112, 42, 83, 119},
                new() {56, 125, 56, 49},
                new() {15, 78, 101, 43},
                new() {62, 98, 114, 108}
            };

            int expected = 414;
            int result = Result.flippingMatrix(mat);

            Assert.AreEqual(expected, result);
        }
    }
}