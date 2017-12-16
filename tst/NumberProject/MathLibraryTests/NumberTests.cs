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
    public class NumberTests
    {
        Number _number;
        [TestInitialize]
        public void TestInitialize()
        {
            _number = new Number();
        }

        [TestMethod()]
        public void divideReturnIntTest()
        {
            double result = _number.divide(10, 2);
            Assert.AreEqual(result, 5);
        }

        [TestMethod()]
        public void divideReturnDoubleTest()
        {
            double result = _number.divide(5, 2);
            Assert.AreEqual(result, 2.5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void divideByZeroTest()
        {
            double result = _number.divide(5, 0);
            Assert.Fail();
        }

        [TestMethod()]
        public void sumTest()
        {
            Assert.AreEqual(_number.sum(10, 2), 12);
        }

        [TestMethod()]
        public void sumNegativeNumberTest()
        {
            Assert.AreEqual(_number.sum(10, -2), 8);
        }
    }
}