using NUnit.Framework;
using System;

namespace MathToolBox.UnitTest
{
    [TestFixture]
    public class MathToolBoxATests
    {
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(11, 89)]
        [Description("Validate Fibonacci function on positive input")]
        public void FibonacciPositiveInput(int value, int expected)
        {
            MathToolBoxA mathToolBox = new MathToolBoxA();

            long result = mathToolBox.Fibonacci(value);

            Assert.AreEqual(result, expected);
        }

        [TestCase(-1)]
        [Description("Validate Fibonacci function on negative input")]
        public void FibonacciNegativeInput(int value)
        {
            MathToolBoxA mathToolBox = new MathToolBoxA();

            Assert.Throws<InvalidOperationException>(() =>
            {
                long result = mathToolBox.Fibonacci(value);
            });
        }
    }
}
