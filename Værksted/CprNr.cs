namespace Værksted;

public class CprNr
{
    private string _bDay;
    private string _sNumber;

    public CprNr(string bDay, string sNumber)
    {
        _bDay = bDay;
        _sNumber = sNumber;
    }

    public string BDay
    {
        get => _bDay;
        set => _bDay = value;
    }

    public string SNumber
    {
        get => _sNumber;
        set => _sNumber = value;
    }

    public override string ToString()
    {
        return BDay + SNumber;
    }
}