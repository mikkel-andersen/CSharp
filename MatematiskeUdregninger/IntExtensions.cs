namespace Extensions;

public static class IntExtensions
{
    public static int Factorial(this int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}