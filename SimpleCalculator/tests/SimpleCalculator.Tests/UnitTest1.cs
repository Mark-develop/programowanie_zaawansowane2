// tests/SimpleCalculator.Tests/CalculatorTests.cs
using NUnit.Framework;
using NUnit.Framework.Legacy;
using SimpleCalculator;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = _calculator.Add(3, 7);
            ClassicAssert.AreEqual(10, result);
        }

        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            int result = _calculator.Add(5, -3);
            ClassicAssert.AreEqual(2, result);
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            int result = _calculator.Add(-4, -6);
            ClassicAssert.AreEqual(-10, result);

        }

        [Test]
        public void Add_ZeroAndNumber_ReturnsNumber()
        {
            int result = _calculator.Add(0, 5);
            ClassicAssert.AreEqual(5, result);
        }
    }
}
