using NUnit.Framework;
using Cfn.OnBoarding.TDD.MathToolBox.ImplA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cfn.OnBoarding.TDD.MathToolBox;

namespace Cfn.OnBoarding.TDD.MathToolBox.ImplA.UnitTests
{
    [TestFixture]
    public class MathToolBoxATests
    {
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [Description("Test Fibonacci sequence when input numbers are positive")]
        public void FibonacciPositiveNumber(int n, int expected)
        {
            //Arrange
            var toolBox = new MathToolBoxA();

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
            var toolBox = new MathToolBoxA();

            //Assert
            Assert.Throws<InvalidOperationException>(
                () =>{
                    var result = toolBox.Fibonacci(n);
                }
            );

        }
    }
}