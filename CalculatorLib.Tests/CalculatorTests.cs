using System;
using CalcularorLib;
using NUnit.Framework;

namespace CalculatorLib.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase]
        public void Add_When_Both_Inputs_GreaterThanZero_Returns_ExpectedResult()
        {
            //Arrange
            Calculator calculator = new Calculator();

            int firstNo = 30;
            int secondNo = 20;

            int expectedResult = 50;

            int actualResult;

            //Act
            actualResult = calculator.Add(firstNo, secondNo);

            //Assert

            Assert.That(expectedResult == actualResult, "Verify the add method logic");
        }
        [TestCase]
        public void Add_When_SecondInput_LessThanOrEqualToZero_Returns_NegativeOne()
        {
            Calculator calculator = new Calculator();

            int firstNo = 30;
            int secondNo = 0;

            int expectedResult = -1;

            int actualResult = calculator.Add(firstNo, secondNo);

            Assert.That(expectedResult == actualResult, "Verify the add method logic");
        }

        [TestCase]
        public void Add_When_FirstInput_LessThanOrEqualToZero_Returns_NegativeTwo()
        {

            Calculator calculator = new Calculator();

            int firstNo = -2;
            int secondNo = 5;

            int expectedResult = -2;

            int actualResult = calculator.Add(firstNo, secondNo);

            Assert.That(expectedResult == actualResult, "Verify the add method logic");
        }

        [TestCase]
        public void Add_When_BothInputs_LessThanOrEqualToZero_Returns_Zero()
        {

            Calculator calculator = new Calculator();

            int firstNo = -2;
            int secondNo = 0;

            int expectedResult = 0;

            int actualResult = calculator.Add(firstNo, secondNo);

            Assert.That(expectedResult == actualResult, "Verify the add method logic");
        }
    }
}
