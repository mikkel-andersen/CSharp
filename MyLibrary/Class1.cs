namespace MyLibrary;

public class Animal : IAnimal
{
    private string specie;

    public Animal(string specie)
    {
        this.specie = specie;
    }

    public bool isDog()
    {
        return specie.Equals("Hund");
    }

    public string getSpecie()
    {
        return specie;
    }
}