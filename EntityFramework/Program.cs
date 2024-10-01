using EntityFramework.DAL;
using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        Context context = new Context();
        context.Database.EnsureDeleted();
        bool created = context.Database.EnsureCreated();
        if (created)
        {
            Console.WriteLine("Database created");
        }

        var ejer = new Ejer
        {
            Name = "Mikkel"
        };

        var newBil = new Bil
        {
            Name = "Mercedes",
            Weight = 2000
        };

        var b = context.Biler.FirstOrDefault(b => b.Name == "BMW");
        ejer.Biler.Add(b);
        ejer.Biler.Add(newBil);
        b.Ejer = ejer; // Opdaterer ejer på et objekt i databasen
        newBil.Ejer = ejer;

        context.Ejer.Add(ejer);
        context.Biler.Add(newBil);
        context.SaveChanges(); // Gemmer ændringer til databasen

        Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", "BilID", "Name", "Weight", "Ejer");
        foreach (var bil in context.Biler)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", bil.BilID, bil.Name, bil.Weight, bil.Ejer?.Name);
        }

        foreach (var e in context.Ejer.Include(e => e.Biler))
        {
            Console.WriteLine($"\nEjer: {e.Name}");
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "BilID", "Name", "Weight");
            foreach (var bil in e.Biler)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", bil.BilID, bil.Name, bil.Weight);
            }
        }
        
        
        var ejer1 = new Ejer { Name = "Mikkel" };
        var ejer2 = new Ejer { Name = "Anders" };

        var fly1 = new Hobbyfly { Model = "Cessna 172" };
        var fly2 = new Hobbyfly { Model = "Piper PA-28" };

        ejer1.Hobbyfly.Add(fly1);
        ejer1.Hobbyfly.Add(fly2);
        ejer2.Hobbyfly.Add(fly1);

        context.Ejer.AddRange(ejer1, ejer2);
        context.Hobbyfly.AddRange(fly1, fly2);
        context.SaveChanges();

        Console.WriteLine("Data initialized");

        foreach (var e in context.Ejer.Include(e => e.Hobbyfly))
        {
            Console.WriteLine($"{e.Name} ejer følgende fly:");
            foreach (var fly in e.Hobbyfly)
            {
                Console.WriteLine($"  {fly.Model}");
                var ejere = context.Hobbyfly.Include(f => f.Ejere).FirstOrDefault(f => f.HobbyflyID == fly.HobbyflyID)?.Ejere;
                if (ejere != null)
                {
                    Console.WriteLine("  Medejere:");
                    foreach (var medejer in ejere)
                    {
                        Console.WriteLine($"    {medejer.Name}");
                    }
                }
            }
        }
    }
}