using Power;

class Program
{
    public static int Power(int n, int p)
    {
        var res = 1;
        for (int i = 0; i < p; i++)
        {
            res *= n;
        }

        return res;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(2.Power(4));
    }
}