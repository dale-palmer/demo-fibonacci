using System;

namespace Fibonacci
{
    public static class FibonacciCalculator
    {
        public static int GetTerm(int term) =>
            term < 2 ? term : GetTerm(term - 1) + GetTerm(term - 2);

        public static bool IsFibonacci(int value) =>
            (value.FiveTimesSquare() + 4).IsSquareNumber() || (value.FiveTimesSquare() - 4).IsSquareNumber();

        private static bool IsSquareNumber(this int x) =>
            Math.Pow((int)Math.Sqrt(x), 2) == x;

        private static int FiveTimesSquare(this int value) =>
            5 * (int)Math.Pow(value, 2);
    }
}
