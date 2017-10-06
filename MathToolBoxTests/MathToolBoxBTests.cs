
using NUnit.Framework;
using System;

namespace MathToolBox.UnitTest
{
    [TestFixture]
    class MathToolBoxBTests
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
                MathToolBoxB mathToolBox = new MathToolBoxB();

                long result = mathToolBox.Fibonacci(value);

                Assert.AreEqual(result, expected);
            }

            [TestCase(-1)]
            [Description("Validate Fibonacci function on negative input")]
            public void FibonacciNegativeInput(int value)
            {
                MathToolBoxB mathToolBox = new MathToolBoxB();

                Assert.Throws<InvalidOperationException>(() =>
                {
                    long result = mathToolBox.Fibonacci(value);
                });
            }
        }
    }
}
