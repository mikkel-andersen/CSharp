using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            MyNormalMethod();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception fanget i Main: {ex.Message}");
        }
    }

    public static void MyNormalMethod(int num = 0)
    {
        try
        {
            Console.WriteLine("Kalder MyMethodWithError...");
            MyMethodWithError(num);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception fanget i MyNormalMethod: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block i MyNormalMethod udført.");
        }
    }

    private static void MyMethodWithError(int num = 0)
    {
        Console.WriteLine("Inde i MyMethodWithError...");
        throw new InvalidOperationException("En fejl er opstået i MyMethodWithError.");
    }
}