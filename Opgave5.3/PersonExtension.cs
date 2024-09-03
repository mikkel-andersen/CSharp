namespace Opgave5._3;

public static class PersonExtensions
{
    public static void SetAcceptedP(this List<Person> lst, Predicate<Person> pred)
    {
        foreach (var person in lst)
        {
            if (pred(person))
            {
                person.Accepted = true;
            }
        }
    }

    public static void Reset(this List<Person> list)
    {
        foreach (var p in list)
        {
            p.Accepted = false;
        }
    }
}