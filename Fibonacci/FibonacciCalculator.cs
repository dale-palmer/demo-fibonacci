namespace Fibonacci
{
    public static class FibonacciCalculator
    {
        public static int Calculate(int n) =>
            n < 2 ? n : Calculate(n - 1) + Calculate(n - 2);
    }
}
