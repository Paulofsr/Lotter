using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Tests
{
    [TestClass()]
    public class NumbersTests
    {
        Numbers _numbers;
        [TestInitialize]
        public void TestInitialize()
        {
            _numbers = new Numbers();
        }

        [TestMethod()]
        public void sumTest()
        {
            var numbers = new Numbers();
            var r = numbers.sum(new List<int>() { 1, 2, 3 }.ToArray());
            Assert.AreEqual(r, 6);
        }

        [TestMethod()]
        public void averageTest()
        {
            Assert.AreEqual(_numbers.average(new List<int>() { 10, 30, 50 }.ToArray()), 30);
        }
    }
}