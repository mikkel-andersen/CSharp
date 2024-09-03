class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            numbers.Add(random.Next(1, 100));
        }

        int distincUlige = numbers.Distinct().Count(n => n % 2 != 0);
        Console.WriteLine(distincUlige);

        int unikkeTal = numbers.Distinct().Count();
        Console.WriteLine(unikkeTal);

        Console.WriteLine("\nTre første ulige: ");

        IEnumerable<int> treFørsteUlige = numbers.Where(n => n % 2 != 0)
            .Take(3)
            .OrderBy(n => n);
        foreach (var n in treFørsteUlige)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nAlle unikke ulige tal: ");
        IEnumerable<int> unikkeUligeTal = numbers.Where(n => n % 2 != 0)
            .Distinct()
            .OrderBy(n => n);
        foreach (var n in unikkeUligeTal)
        {
            Console.WriteLine(n);
        }

    }
}