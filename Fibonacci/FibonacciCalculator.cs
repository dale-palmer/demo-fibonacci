using System;

namespace Fibonacci
{
    public static class FibonacciCalculator
    {
        public static int Calculate(int n) =>
            n < 2 ? n : Calculate(n - 1) + Calculate(n - 2);

        public static bool IsFibonacci(int value)
        {
            var term = 0;
            var result = 0;

            while (result < value)
            {
                result = Calculate(term);
                if (result == value)
                    return true;
                term++;
            }

            return false;
        }
    }
}
