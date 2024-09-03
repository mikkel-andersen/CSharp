class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

        IEnumerable<int> stigendeOrden = numbers.OrderBy(n => n);
        IEnumerable<int> faldendeOrden = numbers.OrderByDescending(n => n);

        Console.WriteLine("Stigende orden");
        foreach (var n in stigendeOrden)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nFaldende orden");
        foreach (var n in faldendeOrden)
        {
            Console.WriteLine(n);
        }

        IEnumerable<string> tal = numbers.OrderBy(n => n)
            .Select(n => n.ToString());
        
        IEnumerable<string> talMedInfo = numbers.OrderBy(n => n)
            .Select(n => $"{n} {(n % 2 == 0 ? "even" : "uneven")}");
        Console.WriteLine("\n tal som strings: ");
        foreach (var n in tal)
        {
            Console.WriteLine(n);
        }
        
        Console.WriteLine("\n tal med info: ");
        foreach (var n in talMedInfo)
        {
            Console.WriteLine(n);
        }
        
        



    }
}