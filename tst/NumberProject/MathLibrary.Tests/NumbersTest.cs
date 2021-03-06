// <copyright file="NumbersTest.cs">Copyright ©  2017</copyright>
using System;
using MathLibrary;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibrary.Tests
{
    /// <summary>This class contains parameterized unit tests for Numbers</summary>
    [PexClass(typeof(Numbers))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class NumbersTest
    {
        /// <summary>Test stub for average(Int32[])</summary>
        [PexMethod]
        public double averageTest([PexAssumeUnderTest]Numbers target, int[] numbers)
        {
            double result = target.average(numbers);
            return result;
            // TODO: add assertions to method NumbersTest.averageTest(Numbers, Int32[])
        }
    }
}
