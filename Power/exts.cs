namespace Power;

public static class exts
{
    public static int Power(this int n, int p)
    {
        var res = 1;
        for (int i = 0; i < p; i++)
        {
            res *= n;
        }

        return res;
    }
}