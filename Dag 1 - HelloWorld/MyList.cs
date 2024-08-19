namespace Dag_1___HelloWorld;

public class MyList
{
    private List<int> list;

    public MyList()
    {
        list = new List<int>();
    }

    public void AddNumber(int number)
    {
        list.Add(number);
    }

    public void PrintNumbers()
    {
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }
    }
}