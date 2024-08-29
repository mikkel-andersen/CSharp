namespace Extensions;

internal static class exts
{
    public static bool Lang(this string str, int n)
    {
        int count = str.Count(char.IsLetter);
        return count > n;
    }
}