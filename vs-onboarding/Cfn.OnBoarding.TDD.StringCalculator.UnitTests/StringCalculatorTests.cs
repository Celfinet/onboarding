using NUnit.Framework;
using Cfn.OnBoarding.TDD.StringCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cfn.OnBoarding.TDD.StringCalculator.UnitTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase("", 0)]
        [Description("Should use Add method when input is an empty string")]
        public void AddTestEmptyString(string input, int expected)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act
            var result = strCalculator.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("1", 1)]
        [Description("Should use Add method when input is an one number string")]
        public void AddTestOneNumberString(string input, int expected)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act
            var result = strCalculator.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("1,2", 3)]
        [Description("Should use Add method when input is a two number string")]
        public void AddTestTwoNumberString(string input, int expected)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act
            var result = strCalculator.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("1,2,3,2", 8)]
        [TestCase("4,2,1,5", 12)]
        [TestCase("1,2,3,2,3,8,2", 21)]
        [Description("Should use Add method when input is an unknown amount of numbers string")]
        public void AddTestUnkwonNumberString(string input, int expected)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act
            var result = strCalculator.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("1,2\n3", 6)]
        [TestCase("1\n2\n3", 6)]
        [TestCase("1\n2,3", 6)]
        [Description("Should use Add method when input has different delimiters")]
        public void AddTestDiffDelimiterString(string input, int expected)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act
            var result = strCalculator.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("//%\n1,2\n3%5", 11)]
        [TestCase("//;\n1,2\n3;5;6", 17)]
        [Description("Should use Add method when input can set delimiters")]
        public void AddTestSetDelimiterString(string input, int expected)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act
            var result = strCalculator.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("//%\n1,-2\n3%5")]
        [Description("Should use Add method when input can set delimiters")]
        public void AddTestNegNumbersString(string input)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act within Assert

            //Assert
            Assert.Throws<NegativeNotAllowedException>(
                () =>
                {
                    var result = strCalculator.Add(input);
                }
            );
        }

        [TestCase("1,1000,3,5", 9)]
        [TestCase("2,1001", 2)]
        [Description("Should use Add method when input has numbers bigger than 1000")]
        public void AddTestBigNumberstring(string input, int expected)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act
            var result = strCalculator.Add(input);

            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestCase("//[***]\n1***2***3", 6)]
        [Description("Should use Add method when input can set delimiters within brackets")]
        public void AddTestSetDelimiterWithinBracketsString(string input, int expected)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act
            var result = strCalculator.Add(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase("//[*][%]\n1*2%3", 6)]
        [TestCase("//[*][%#]\n1*2%#3", 6)]
        [Description("Should use Add method when input can set multiples delimiters within brackets")]
        public void AddTestSetMultiplesDelimiterWithinBracketsString(string input, int expected)
        {

            //Arrange
            var strCalculator = new StringCalculator();

            //Act
            var result = strCalculator.Add(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}