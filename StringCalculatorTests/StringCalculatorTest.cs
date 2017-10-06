using NUnit.Framework;
using StringCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTests
{
    [TestFixture]
    class StringCalculatorTest
    {
        [TestCase("")]
        [Description("Validate emptyString on String Calculator")]
        public void StringCalculatorEmptyString(string input)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(input);

            Assert.AreEqual(result, 0);
        }

        [TestCase("1")]
        [Description("Validate 1 number on String Calculator")]
        public void StringCalculatorOneNumber(string input)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(input);

            Assert.AreEqual(result, 1);
        }

        [TestCase("1,2")]
        [Description("Validate 2 number on String Calculator")]
        public void StringCalculatorTwoNumber(string input)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(input);

            Assert.AreEqual(result, 3);
        }

        [TestCase("1,2,3,4,5")]
        [Description("Validate 2+ number on String Calculator")]
        public void StringCalculatorTwoMoreNumber(string input)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(input);

            Assert.AreEqual(result, 15);
        }

        [TestCase("1,2a,3;,4,5")]
        [Description("Validate invalid input on String Calculator")]
        public void StringCalculatorInvalidInput(string input)
        {
            Calculator calculator = new Calculator();
            
            Assert.Throws<InvalidOperationException>(() =>
            {

                var result = calculator.Add(input);
            });
        }

        [TestCase("1,2\n3,4,5")]
        [Description("Validate new lines on String Calculator")]
        public void StringCalculatorNewlLnesInput(string input)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(input);

            Assert.AreEqual(result, 15);
        }

        [TestCase("//;\n1;2")]
        [Description("Validate delimiters on String Calculator")]
        public void StringCalculatorSupportDelimiter(string input)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(input);

            Assert.AreEqual(result, 3);
        }

        [TestCase("//;\n1;2;-3;-4")]
        [Description("Validate negative not allowed on String Calculator")]
        public void StringCalculatorNegativeNotAllowed(string input)
        {
            Calculator calculator = new Calculator();

            Assert.Throws<NegativeNotAllowedException>(() =>
            {
                var result = calculator.Add(input);
            });
        }

        [TestCase("//;\n1;2;1001;4")]
        [Description("Validate numbers bigger than 1000 should be ignored on String Calculator")]
        public void StringCalculatorMoreThan1000Ignore(string input)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(input);

            Assert.AreEqual(result, 7);
        }

        [TestCase("//[***]\n1***2***3")]
        [Description("Validate any format of delimiters on String Calculator")]
        public void StringCalculatorSupportDelimiterAnyFormat(string input)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(input);

            Assert.AreEqual(result, 6);
        }

        [TestCase("//[*][%]\n1*2%3")]
        [Description("Validate multiple delimiters on String Calculator")]
        public void StringCalculatorMultipleDelimiter(string input)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Add(input);

            Assert.AreEqual(result, 6);
        }
    }
}
