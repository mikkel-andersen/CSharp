using MyLibrary;

namespace Dag_1___HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mikkel");
            Console.WriteLine(person);
            person.setName("Mathias");
            Console.WriteLine(person);

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
            for (int i = 0; i < 10; i++)
            {
                liste2.AddNumber(rand.Next(1000));
            }
            liste2.PrintNumbers();

        }
    }
}