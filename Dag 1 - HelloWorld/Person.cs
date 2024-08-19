namespace Dag_1___HelloWorld;

public class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return name;
    }
}