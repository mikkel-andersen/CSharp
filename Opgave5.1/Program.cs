
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Opgave 5.1");
        List<int> liste = new List<int>() { 4, 2, 19, 23, 17, 5, 9, 10 };

        Console.WriteLine();
        List<int> ligeTal = liste.Where(n => n % 2 == 0).ToList();
        ligeTal.ForEach(n => Console.WriteLine(n));

        Console.WriteLine();
        int lastOver15 = liste.LastOrDefault(n => n > 15);
        Console.WriteLine(lastOver15);

        Console.WriteLine();
        int lastIndexOver15 = liste.FindLastIndex(n => n > 15);
        Console.WriteLine(lastIndexOver15);
        
        
        Console.WriteLine("Opgave 5.2");
        IEnumerable<int> even = liste.Where(n => n % 2 == 0).OrderBy(n => n);
        foreach (var x in even)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine();
        IEnumerable<int> toCifre = liste.Where(n => n.ToString().Length == 2).OrderBy(n => n);;
        foreach (var n in toCifre)
        {
            Console.WriteLine(n);
        }

    }
}
