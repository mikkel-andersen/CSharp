// See https://aka.ms/new-console-template for more information

namespace Delegates;

class Program
{
    
    static void Main(string[] args)
    {
        Operation f1 = Add;
     
        CalculateAndDisplay(10, 20, f1);
        f1 = Multiply;
        
        CalculateAndDisplay(1293, 483, f1);
    }
    
    
    public delegate int Operation(int a, int b);

    public static void CalculateAndDisplay(int a, int b, Operation operation)
    {
        Console.WriteLine($"a: {a} og b: {b}");
        Console.WriteLine($"Resultat: {operation(a,b)}");
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

   

}