using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using SimpleCalculator_2;

namespace SimpleCalculator_2.Tests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _result;
        private Calculator _calculator = new Calculator();

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _firstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _secondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add(_firstNumber, _secondNumber);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _result);
        }
    }
}
