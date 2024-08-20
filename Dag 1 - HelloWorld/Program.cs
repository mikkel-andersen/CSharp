using Dag_1___HelloWorld;
using MyLibrary;
// Dag 1
       
List<Person> persons = new List<Person>();
Person person = new Person("Mikkel");
persons.Add(person);
Console.WriteLine(person.Fornavn);
person.Fornavn = "Mathias";
Console.WriteLine(person);
Person person2 = new Person("Tully");
persons.Add(person2);

foreach (var p in persons)
{
    Console.WriteLine(p);
}

var hund = new Animal("Hund");
Console.WriteLine("Er hunden en hund? " +  hund.isDog());
            
Console.WriteLine();
Console.WriteLine("Hvilket dyr ønskes? ");

string dyr = Console.ReadLine();
var animal = new Animal(dyr);
Console.WriteLine("Er dyret en hund? " +  animal.isDog());
Console.WriteLine("Dyret er en: " + animal.getSpecie());
            
Console.WriteLine();
var liste = new MyList();
liste.AddNumber(1);
liste.AddNumber(2);
liste.AddNumber(4);
liste.AddNumber(9);
liste.AddNumber(10);
liste.PrintNumbers();

var rand = new Random();
var liste2 = new MyList();
for (int i = 0; i < 4; i++)
{
    liste2.AddNumber(rand.Next(3));
}
liste2.PrintNumbers();