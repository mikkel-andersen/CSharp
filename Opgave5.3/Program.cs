using System.Threading.Channels;
using Opgave5._3;

public class Person
{
   
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    public int Score { get; set; }
    public bool Accepted { get; set; }

    public Person(string data)
    {
        // Name, Age, Weight, Score
        var L = data.Split(';');
        Name = L[0];
        Age = int.Parse(L[1]);
        Weight = int.Parse(L[2]);
        Score = int.Parse(L[3]);
        Accepted = false; //denne parameter bliver ikke indlæst, men skal bruges senere.
    }

    public static List<Person> ReadCSVFile(string filename)
    {
        List<Person> list = new List<Person>();
        using (var file = new StreamReader(filename))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                var p = new Person(line);
                list.Add(p);
                //Console.WriteLine(p);
            }
        }

        return list;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Weigth: {Weight}," +
               $" Score: {Score} & Accepted: {Accepted}";
    }
    

    static void Main(string[] args)
    {
        List<Person> people1 = Person.ReadCSVFile(
            @"/Users/mikkel/Documents/Datamatiker/4. semester/C# & .NET/Lektioner/Opgave5.3/data1.csv");

        List<Person> people2 =
            Person.ReadCSVFile(
                "/Users/mikkel/Documents/Datamatiker/4. semester/C# & .NET/Lektioner/Opgave5.3/data2.csv");

        List<Person> under2 = people1.FindAll(n => n.Score < 2);
        List<Person> ligeScore = people1.FindAll(n => n.Score % 2 == 0);
        List<Person> over60 = people1.FindAll(n => n.Weight > 60);
        List<Person> deleMed3 = people1.FindAll(n => n.Weight % 3 == 0);

        Console.WriteLine("Score under 2");
        under2.ForEach(n => Console.WriteLine(n));

        Console.WriteLine("\nAlle med lige score");
        ligeScore.ForEach(n => Console.WriteLine(n));

        Console.WriteLine("\nWeight over 60");
        over60.ForEach(n => Console.WriteLine(n));

        Console.WriteLine("\nWeight deleligt med 3");
        deleMed3.ForEach(n => Console.WriteLine(n));

        Console.WriteLine("Opgave 5.4");

        var indexScore3 = people1.FindIndex(n => n.Score == 3); // Returnerer int - Index
        var indexScore3AlderUnder10 = people1.FindIndex(n => n.Age < 10 && n.Score == 3); // Returnerer int - Index
        List<Person> antalUnder10 = people1.FindAll(n => n.Age < 10 && n.Score == 3); // Returnerer liste
        var indexUnder8 = people1.FindIndex(n => n.Age < 8 && n.Score == 3); // Returnerer int -1 fordi den ikke findes

        Console.WriteLine($"Index på første person med score == 3: {indexScore3} ");
        Console.WriteLine($"Index på første person med alder < 10 og score == 3: {indexScore3AlderUnder10}");
        Console.WriteLine($"Antal personer med alder < 10 med score == 3: {antalUnder10.Count}");
        Console.WriteLine($"Index på første person med alder < 8 og score == 3: {indexUnder8} <-- Findes ikke");
        
        people1.SetAcceptedP(p => p.Score >= 6 && p.Age <= 40);
        people1.ForEach(n => Console.WriteLine(n));

        Console.WriteLine("\nOpgave 5.7");
        IEnumerable<Person> people = people1.OrderBy(n => n.Age)
            .ThenBy(n => n.Score);
        foreach (var p in people)
        {
            Console.WriteLine(p);
        }
        
        people1.Reset();
        people1.ForEach(n => Console.WriteLine(n));

        var groupByLetter =
            from person in people1
            group person by person.Name.Substring(0, 1)
            into newGroup
            orderby newGroup.Key
            select newGroup;

        foreach (var group in groupByLetter)
        {
            Console.WriteLine($"Group: {group.Key}");
            foreach (var person in group)
            {
                Console.WriteLine(person);
            }
        }

        var personerPaaBeggeLister =
            from person in people1
            join person2 in people2
                on person.Name equals person2.Name
            select new
            {
                person.Name,
                person.Age,
                person.Weight,
                person.Score,
                person.Accepted
            };

        foreach (var p in personerPaaBeggeLister)
        {
            Console.WriteLine(p);
        }




    }
}