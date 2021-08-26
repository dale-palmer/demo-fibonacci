using NUnit.Framework;

namespace Fibonacci.Tests
{
    class FibonacciCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        public void FibonacciCalculator_Calculate_WithTerm_ReturnsValue(int term, int expected)
        {
            var actual = FibonacciCalculator.Calculate(term);

            Assert.AreEqual(expected, actual);
        }
    }
}
