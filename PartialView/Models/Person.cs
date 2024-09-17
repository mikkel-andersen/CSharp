public class Person
{
    public string Navn { get; set; }
    public string Efternavn { get; set; }
    public int Age { get; set; }

    public Person(string navn, string efternavn, int age)
    {
        Navn = navn;
        Efternavn = efternavn;
        Age = age;
    }
}