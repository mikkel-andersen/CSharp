using System;

class Program
{
    static void Main(string[] args)
    {
        // Iterativ Fibonacci
        Console.WriteLine("Vælg højeste fibonacci tal: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------");
        Fibonacci(input);

        // Rekursiv Fibonacci
        Console.WriteLine("");
        Console.WriteLine("Rekursiv fibonacci");
        Console.WriteLine("Vælg højeste fibonacci tal: ");
        int input2 = int.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------");
        for (int i = 0; i < input2; i++)
        {
            Console.WriteLine(FibonacciRecursive(i));
        }
    }

    static void Fibonacci(int n)
    {
        int a = 0, b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);
            int temp = a;
            a = b;
            b = temp + b;
        }
    }

    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        {
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}