using Cfn.OnBoarding.TDD.MathToolBox;
using Moq;
using NUnit.Framework;

namespace Cfn.OnBoarding.TDD.Classroom.Math.UnitTests
{
    [TestFixture]
    public class MathClassroomTests
    {
        [TestCase(5, 5)]
        [Description("Should print the expected exercises report")]
        public void PrintExercisesReport(int n, int fib)
        {
            //Arrange
            var mock = new Mock<IMathToolBox>();
            mock.Setup(tb => tb.Fibonacci(n)).Returns(fib);
            var classroom = new MathClassroom(mock.Object);
            var expected = $"Fibonacci of {n} is: {fib}\n";

            //Act
            var report = classroom.GetExercicesReport(5);

            //Assert
            Assert.AreEqual(expected, report);
        }

        [Test]
        public void test()
        {
            IMathToolBox toolbox = null;
            var res = toolbox?.Fibonacci(5) ?? 0;
            //int? res = null;
            //if (toolbox != null)
            //{
            //    res = toolbox.Fibonacci(5);
            //}
        }
    }
}