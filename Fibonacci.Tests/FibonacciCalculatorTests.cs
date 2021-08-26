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

        [TestCase(5, true)]
        [TestCase(8, true)]
        [TestCase(21, true)]
        [TestCase(10, false)]
        [TestCase(25, false)]
        public void FibonacciCalculator_IsFibonacci_WithValue_ReturnsResult(int value, bool expected)
        {
            var actual = FibonacciCalculator.IsFibonacci(value);

            Assert.AreEqual(expected, actual);
        }
    }
}
