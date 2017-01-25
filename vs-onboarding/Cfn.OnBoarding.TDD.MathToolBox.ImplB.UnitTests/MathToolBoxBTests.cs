using NUnit.Framework;
using System;

namespace Cfn.OnBoarding.TDD.MathToolBox.ImplB.UnitTests
{
    [TestFixture]
    public class MathToolBoxBTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [Description("Test Fibonacci sequence when input numbers are positive")]
        public void FibonacciPositiveNumber(int n, int expected)
        {
            //Arrange
            var toolBox = new MathToolBoxB();

            //Act
            var result = toolBox.Fibonacci(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [Description("Test Fibonacci sequence when input numbers non positive")]
        public void FibonacciNonPositiveNumber(int n)
        {
            //Arrange
            var toolBox = new MathToolBoxB();

            //Assert
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    var result = toolBox.Fibonacci(n);
                }
            );
        }
    }
}